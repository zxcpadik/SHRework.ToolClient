using SHGui;

namespace SHRework.ToolClient;
public partial class MainForm : Form {

    SHProto proto = new SHProto("localhost");
    public ConfigManager ConfigManager = new ConfigManager();

    public MainForm() {
        InitializeComponent();

        panels.Add("Auth", auth_panel);
        panels.Add("Create", create_panel);
        panels.Add("Change", change_panel);
        panels.Add("Delete", delete_panel);
        panels.Add("Flush", flush_panel);
        panels.Add("Last", last_panel);
        panels.Add("Pull", pull_panel);
        panels.Add("Push", push_panel);

        auth_panel.Parent = this;
        create_panel.Parent = this;
        change_panel.Parent = this;
        delete_panel.Parent = this;
        flush_panel.Parent = this;
        last_panel.Parent = this;
        pull_panel.Parent = this;
        push_panel.Parent = this;

        auth_panel.Location = new Point(197, 26);
        create_panel.Location = new Point(197, 26);
        change_panel.Location = new Point(197, 26);
        delete_panel.Location = new Point(197, 26);
        flush_panel.Location = new Point(197, 26);
        last_panel.Location = new Point(197, 26);
        pull_panel.Location = new Point(197, 26);
        push_panel.Location = new Point(197, 26);
    }

    Dictionary<string, Control> panels = new Dictionary<string, Control>();

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
        foreach (var item in panels) { item.Value.Enabled = false; item.Value.Visible = false; }
        var val = listBox1.Items[listBox1.SelectedIndex].ToString();
        if (!panels.ContainsKey(val)) return;
        panels[val].Enabled = true;
        panels[val].Visible = true;
        Controls.SetChildIndex(panels[val], 0);
    }

    private void auth_submit_Click(object sender, EventArgs e) {
        var result = proto.RequestAuth(new Credentials() { username = auth_username.Text, password = auth_password.Text });

        StringWriter sw = new StringWriter();
        sw.WriteLine($"[AUTH] OK:{result.ok} {result.status}");
        if (result.ok) sw.WriteLine($"\tUserID: {result.ID}");
        log_box.Text += sw.GetStringBuilder().ToString();
    }

    private void create_button_Click(object sender, EventArgs e) {
        var result = proto.RequestCreate(new Credentials() { username = create_username.Text, password = create_password.Text });

        StringWriter sw = new StringWriter();
        sw.WriteLine($"[CREATE] OK:{result.ok} {result.status}");
        if (result.ok) sw.WriteLine($"\tUserID: {result.ID}");
        log_box.Text += sw.GetStringBuilder().ToString();
    }

    private void change_button_Click(object sender, EventArgs e) {
        var result = proto.RequestChange(new Credentials() { username = change_username.Text, password = change_password.Text }, change_newpassword.Text);

        StringWriter sw = new StringWriter();
        sw.WriteLine($"[CHANGE] OK:{result.ok} {result.status}");
        if (result.ok) sw.WriteLine($"\tUserID: {result.ID}");
        log_box.Text += sw.GetStringBuilder().ToString();
    }

    private void delete_button_Click(object sender, EventArgs e) {
        var result = proto.RequestDelete(new Credentials() { username = delete_username.Text, password = delete_password.Text });

        StringWriter sw = new StringWriter();
        sw.WriteLine($"[DELETE] OK:{result.ok} {result.status}");
        log_box.Text += sw.GetStringBuilder().ToString();
    }

    private void flush_button_Click(object sender, EventArgs e) {
        var result = proto.RequestFlush(new Credentials() { username = flush_username.Text, password = flush_password.Text });

        StringWriter sw = new StringWriter();
        sw.WriteLine($"[FLUSH] {(result.ok ? "OK" : "ERR")} {result.status}");
        if (result.ok) sw.WriteLine($"\tCount: {result.count}");
        log_box.Text += sw.GetStringBuilder().ToString();
    }

    private void last_button_Click(object sender, EventArgs e) {
        var result = proto.RequestLast(new Credentials() { username = last_username.Text, password = last_password.Text });

        StringWriter sw = new StringWriter();
        sw.WriteLine($"[FLUSH] {(result.ok ? "OK" : "ERR")} {result.status}");
        if (result.ok) sw.WriteLine($"\tLast: {result.count}");
        log_box.Text += sw.GetStringBuilder().ToString();
    }


    private void TextBox_Only_Numbers(object sender, KeyPressEventArgs e) {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
            e.Handled = true;
        }
    }
    private void pull_button_Click(object sender, EventArgs e) {
        int offset;
        if (!int.TryParse(pull_offset.Text, out offset)) {
            log_box.Text += "[PULL] OFFSET INVALID\n";
            return;
        }

        int count;
        if (!int.TryParse(pull_count.Text, out count)) {
            log_box.Text += "[PULL] COUNT INVALID\n";
            return;
        }

        var result = proto.RequestPull(new Credentials() { username = pull_username.Text, password = pull_password.Text }, offset, count);

        StringWriter sw = new StringWriter();
        sw.WriteLine($"[PULL] {(result.ok ? "OK" : "ERR")} {result.status}");

        if (result.ok) {
            sw.WriteLine($"Tickets: {result.tickets?.Length}");

            for (int i = 0; i < result.tickets?.Length; i++) {
                Ticket t = result.tickets[i];
                sw.WriteLine($"--- ID {t.TicketID} ---");
                sw.WriteLine($"\tGlobalID: {t.GlobalID}");
                sw.WriteLine($"\tResponseID: {t.ResponseID}");
                sw.WriteLine($"\tSourceID: {t.SourceID}");
                sw.WriteLine($"\tDestinationID: {t.DestinationID}");
                sw.WriteLine($"\tDate: {t.Date}");
                sw.WriteLine($"\tData: \n{t.Data}\n");
            }
        }

        log_box.Text += sw.GetStringBuilder().ToString();
    }

    private void clear_button_Click(object sender, EventArgs e) {
        log_box.Clear();
    }

    private void push_button_Click(object sender, EventArgs e) {
        int destinationid;
        if (!int.TryParse(push_destination.Text, out destinationid)) {
            log_box.Text += "[PUSH] DestinationID INVALID\n";
            return;
        }

        int responseid = default;
        if (push_responseid.Text != string.Empty && !int.TryParse(push_responseid.Text, out responseid)) {
            log_box.Text += "[PULL] COUNT INVALID\n";
            return;
        }

        TicketResult result;
        if (push_responseid.Text != string.Empty) result = proto.RequestPush(new Credentials() { username = push_username.Text, password = push_password.Text }, destinationid, push_data.Text, responseid);
        else result = proto.RequestPush(new Credentials() { username = push_username.Text, password = push_password.Text }, destinationid, push_data.Text, null);

        StringWriter sw = new StringWriter();
        sw.WriteLine($"[PUSH] {(result.ok ? "OK" : "ERR")} {result.status}");

        if (result.ok) {
            Ticket t = result.tickets[0];
            sw.WriteLine($"--- ID {t.TicketID} ---");
            sw.WriteLine($"\tGlobalID: {t.GlobalID}");
            sw.WriteLine($"\tResponseID: {t.ResponseID}");
            sw.WriteLine($"\tDate: {t.Date}");
        }

        log_box.Text += sw.GetStringBuilder().ToString();
    }

    private void aToolStripMenuItem_Click(object sender, EventArgs e) {

    }
}
