namespace SHRework.ToolClient;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        menuStrip1 = new MenuStrip();
        toolStripMenuItem1 = new ToolStripMenuItem();
        aToolStripMenuItem = new ToolStripMenuItem();
        bToolStripMenuItem = new ToolStripMenuItem();
        log_box = new RichTextBox();
        listBox1 = new ListBox();
        auth_username = new TextBox();
        auth_password = new TextBox();
        label1 = new Label();
        label2 = new Label();
        auth_panel = new Panel();
        delete_panel = new Panel();
        delete_button = new Button();
        label8 = new Label();
        label9 = new Label();
        delete_username = new TextBox();
        delete_password = new TextBox();
        auth_submit = new Button();
        create_panel = new Panel();
        create_button = new Button();
        change_panel = new Panel();
        change_newpassword = new TextBox();
        flush_panel = new Panel();
        flush_button = new Button();
        last_panel = new Panel();
        last_button = new Button();
        label12 = new Label();
        label13 = new Label();
        last_username = new TextBox();
        last_password = new TextBox();
        label10 = new Label();
        label11 = new Label();
        flush_username = new TextBox();
        flush_password = new TextBox();
        label7 = new Label();
        change_button = new Button();
        label5 = new Label();
        label6 = new Label();
        change_username = new TextBox();
        change_password = new TextBox();
        label3 = new Label();
        label4 = new Label();
        create_username = new TextBox();
        create_password = new TextBox();
        pull_panel = new Panel();
        label17 = new Label();
        push_panel = new Panel();
        label22 = new Label();
        push_responseid = new TextBox();
        label18 = new Label();
        push_data = new TextBox();
        label19 = new Label();
        push_destination = new TextBox();
        push_button = new Button();
        label20 = new Label();
        label21 = new Label();
        push_username = new TextBox();
        push_password = new TextBox();
        pull_count = new TextBox();
        label16 = new Label();
        pull_offset = new TextBox();
        pull_button = new Button();
        label14 = new Label();
        label15 = new Label();
        pull_username = new TextBox();
        pull_password = new TextBox();
        clear_button = new Button();
        menuStrip1.SuspendLayout();
        auth_panel.SuspendLayout();
        delete_panel.SuspendLayout();
        create_panel.SuspendLayout();
        change_panel.SuspendLayout();
        flush_panel.SuspendLayout();
        last_panel.SuspendLayout();
        pull_panel.SuspendLayout();
        push_panel.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        menuStrip1.BackColor = Color.Transparent;
        menuStrip1.BackgroundImageLayout = ImageLayout.None;
        menuStrip1.Dock = DockStyle.None;
        menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
        menuStrip1.LayoutStyle = ToolStripLayoutStyle.Flow;
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.RenderMode = ToolStripRenderMode.System;
        menuStrip1.Size = new Size(126, 42);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // toolStripMenuItem1
        // 
        toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { aToolStripMenuItem, bToolStripMenuItem });
        toolStripMenuItem1.Name = "toolStripMenuItem1";
        toolStripMenuItem1.Size = new Size(118, 19);
        toolStripMenuItem1.Text = "SHRework Toolbox";
        // 
        // aToolStripMenuItem
        // 
        aToolStripMenuItem.Image = Properties.Resources.preference;
        aToolStripMenuItem.Name = "aToolStripMenuItem";
        aToolStripMenuItem.Size = new Size(180, 22);
        aToolStripMenuItem.Text = "Параметры";
        aToolStripMenuItem.Click += aToolStripMenuItem_Click;
        // 
        // bToolStripMenuItem
        // 
        bToolStripMenuItem.Image = Properties.Resources.info_button;
        bToolStripMenuItem.Name = "bToolStripMenuItem";
        bToolStripMenuItem.Size = new Size(180, 22);
        bToolStripMenuItem.Text = "О программе";
        // 
        // log_box
        // 
        log_box.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        log_box.BorderStyle = BorderStyle.FixedSingle;
        log_box.Location = new Point(449, 12);
        log_box.Name = "log_box";
        log_box.ReadOnly = true;
        log_box.Size = new Size(270, 477);
        log_box.TabIndex = 1;
        log_box.Text = "";
        // 
        // listBox1
        // 
        listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        listBox1.BorderStyle = BorderStyle.FixedSingle;
        listBox1.FormattingEnabled = true;
        listBox1.ItemHeight = 15;
        listBox1.Items.AddRange(new object[] { "Auth", "Change", "Create", "Delete", "Flush", "Last", "Pull", "Push" });
        listBox1.Location = new Point(12, 26);
        listBox1.Name = "listBox1";
        listBox1.Size = new Size(179, 272);
        listBox1.Sorted = true;
        listBox1.TabIndex = 2;
        listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        // 
        // auth_username
        // 
        auth_username.BorderStyle = BorderStyle.FixedSingle;
        auth_username.Location = new Point(69, 8);
        auth_username.Name = "auth_username";
        auth_username.Size = new Size(174, 23);
        auth_username.TabIndex = 3;
        // 
        // auth_password
        // 
        auth_password.BorderStyle = BorderStyle.FixedSingle;
        auth_password.Location = new Point(69, 37);
        auth_password.Name = "auth_password";
        auth_password.Size = new Size(174, 23);
        auth_password.TabIndex = 4;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(3, 10);
        label1.Name = "label1";
        label1.Size = new Size(60, 15);
        label1.TabIndex = 5;
        label1.Text = "Username";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(6, 39);
        label2.Name = "label2";
        label2.Size = new Size(57, 15);
        label2.TabIndex = 6;
        label2.Text = "Password";
        // 
        // auth_panel
        // 
        auth_panel.Controls.Add(delete_panel);
        auth_panel.Controls.Add(auth_submit);
        auth_panel.Controls.Add(label1);
        auth_panel.Controls.Add(label2);
        auth_panel.Controls.Add(auth_username);
        auth_panel.Controls.Add(auth_password);
        auth_panel.Enabled = false;
        auth_panel.Location = new Point(197, 26);
        auth_panel.Name = "auth_panel";
        auth_panel.Size = new Size(246, 272);
        auth_panel.TabIndex = 7;
        auth_panel.Visible = false;
        // 
        // delete_panel
        // 
        delete_panel.Controls.Add(delete_button);
        delete_panel.Controls.Add(label8);
        delete_panel.Controls.Add(label9);
        delete_panel.Controls.Add(delete_username);
        delete_panel.Controls.Add(delete_password);
        delete_panel.Enabled = false;
        delete_panel.Location = new Point(0, 0);
        delete_panel.Name = "delete_panel";
        delete_panel.Size = new Size(246, 272);
        delete_panel.TabIndex = 9;
        delete_panel.Visible = false;
        // 
        // delete_button
        // 
        delete_button.Location = new Point(88, 66);
        delete_button.Name = "delete_button";
        delete_button.Size = new Size(75, 23);
        delete_button.TabIndex = 7;
        delete_button.Text = "Отправить";
        delete_button.UseVisualStyleBackColor = true;
        delete_button.Click += delete_button_Click;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(3, 10);
        label8.Name = "label8";
        label8.Size = new Size(60, 15);
        label8.TabIndex = 5;
        label8.Text = "Username";
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(6, 39);
        label9.Name = "label9";
        label9.Size = new Size(57, 15);
        label9.TabIndex = 6;
        label9.Text = "Password";
        // 
        // delete_username
        // 
        delete_username.BorderStyle = BorderStyle.FixedSingle;
        delete_username.Location = new Point(69, 8);
        delete_username.Name = "delete_username";
        delete_username.Size = new Size(174, 23);
        delete_username.TabIndex = 3;
        // 
        // delete_password
        // 
        delete_password.BorderStyle = BorderStyle.FixedSingle;
        delete_password.Location = new Point(69, 37);
        delete_password.Name = "delete_password";
        delete_password.Size = new Size(174, 23);
        delete_password.TabIndex = 4;
        // 
        // auth_submit
        // 
        auth_submit.Location = new Point(88, 66);
        auth_submit.Name = "auth_submit";
        auth_submit.Size = new Size(75, 23);
        auth_submit.TabIndex = 7;
        auth_submit.Text = "Отправить";
        auth_submit.UseVisualStyleBackColor = true;
        auth_submit.Click += auth_submit_Click;
        // 
        // create_panel
        // 
        create_panel.Controls.Add(create_button);
        create_panel.Controls.Add(change_panel);
        create_panel.Controls.Add(label3);
        create_panel.Controls.Add(label4);
        create_panel.Controls.Add(create_username);
        create_panel.Controls.Add(create_password);
        create_panel.Enabled = false;
        create_panel.Location = new Point(197, 26);
        create_panel.Name = "create_panel";
        create_panel.Size = new Size(246, 272);
        create_panel.TabIndex = 8;
        create_panel.Visible = false;
        // 
        // create_button
        // 
        create_button.Location = new Point(88, 66);
        create_button.Name = "create_button";
        create_button.Size = new Size(75, 23);
        create_button.TabIndex = 7;
        create_button.Text = "Отправить";
        create_button.UseVisualStyleBackColor = true;
        create_button.Click += create_button_Click;
        // 
        // change_panel
        // 
        change_panel.BackColor = SystemColors.Control;
        change_panel.Controls.Add(change_newpassword);
        change_panel.Controls.Add(flush_panel);
        change_panel.Controls.Add(label7);
        change_panel.Controls.Add(change_button);
        change_panel.Controls.Add(label5);
        change_panel.Controls.Add(label6);
        change_panel.Controls.Add(change_username);
        change_panel.Controls.Add(change_password);
        change_panel.Enabled = false;
        change_panel.Location = new Point(0, 0);
        change_panel.Name = "change_panel";
        change_panel.Size = new Size(246, 272);
        change_panel.TabIndex = 9;
        change_panel.Visible = false;
        // 
        // change_newpassword
        // 
        change_newpassword.BorderStyle = BorderStyle.FixedSingle;
        change_newpassword.Location = new Point(69, 66);
        change_newpassword.Name = "change_newpassword";
        change_newpassword.Size = new Size(174, 23);
        change_newpassword.TabIndex = 9;
        // 
        // flush_panel
        // 
        flush_panel.Controls.Add(flush_button);
        flush_panel.Controls.Add(last_panel);
        flush_panel.Controls.Add(label10);
        flush_panel.Controls.Add(label11);
        flush_panel.Controls.Add(flush_username);
        flush_panel.Controls.Add(flush_password);
        flush_panel.Enabled = false;
        flush_panel.Location = new Point(0, 0);
        flush_panel.Name = "flush_panel";
        flush_panel.Size = new Size(246, 272);
        flush_panel.TabIndex = 10;
        flush_panel.Visible = false;
        // 
        // flush_button
        // 
        flush_button.Location = new Point(88, 66);
        flush_button.Name = "flush_button";
        flush_button.Size = new Size(75, 23);
        flush_button.TabIndex = 7;
        flush_button.Text = "Отправить";
        flush_button.UseVisualStyleBackColor = true;
        flush_button.Click += flush_button_Click;
        // 
        // last_panel
        // 
        last_panel.Controls.Add(last_button);
        last_panel.Controls.Add(label12);
        last_panel.Controls.Add(label13);
        last_panel.Controls.Add(last_username);
        last_panel.Controls.Add(last_password);
        last_panel.Enabled = false;
        last_panel.Location = new Point(0, 0);
        last_panel.Name = "last_panel";
        last_panel.Size = new Size(246, 272);
        last_panel.TabIndex = 11;
        last_panel.Visible = false;
        // 
        // last_button
        // 
        last_button.Location = new Point(88, 66);
        last_button.Name = "last_button";
        last_button.Size = new Size(75, 23);
        last_button.TabIndex = 7;
        last_button.Text = "Отправить";
        last_button.UseVisualStyleBackColor = true;
        last_button.Click += last_button_Click;
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Location = new Point(3, 10);
        label12.Name = "label12";
        label12.Size = new Size(60, 15);
        label12.TabIndex = 5;
        label12.Text = "Username";
        // 
        // label13
        // 
        label13.AutoSize = true;
        label13.Location = new Point(6, 39);
        label13.Name = "label13";
        label13.Size = new Size(57, 15);
        label13.TabIndex = 6;
        label13.Text = "Password";
        // 
        // last_username
        // 
        last_username.BorderStyle = BorderStyle.FixedSingle;
        last_username.Location = new Point(69, 8);
        last_username.Name = "last_username";
        last_username.Size = new Size(174, 23);
        last_username.TabIndex = 3;
        // 
        // last_password
        // 
        last_password.BorderStyle = BorderStyle.FixedSingle;
        last_password.Location = new Point(69, 37);
        last_password.Name = "last_password";
        last_password.Size = new Size(174, 23);
        last_password.TabIndex = 4;
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Location = new Point(3, 10);
        label10.Name = "label10";
        label10.Size = new Size(60, 15);
        label10.TabIndex = 5;
        label10.Text = "Username";
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Location = new Point(6, 39);
        label11.Name = "label11";
        label11.Size = new Size(57, 15);
        label11.TabIndex = 6;
        label11.Text = "Password";
        // 
        // flush_username
        // 
        flush_username.BorderStyle = BorderStyle.FixedSingle;
        flush_username.Location = new Point(69, 8);
        flush_username.Name = "flush_username";
        flush_username.Size = new Size(174, 23);
        flush_username.TabIndex = 3;
        // 
        // flush_password
        // 
        flush_password.BorderStyle = BorderStyle.FixedSingle;
        flush_password.Location = new Point(69, 37);
        flush_password.Name = "flush_password";
        flush_password.Size = new Size(174, 23);
        flush_password.TabIndex = 4;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(6, 70);
        label7.Name = "label7";
        label7.Size = new Size(57, 15);
        label7.TabIndex = 8;
        label7.Text = "New pass";
        // 
        // change_button
        // 
        change_button.Location = new Point(88, 95);
        change_button.Name = "change_button";
        change_button.Size = new Size(75, 23);
        change_button.TabIndex = 7;
        change_button.Text = "Отправить";
        change_button.UseVisualStyleBackColor = true;
        change_button.Click += change_button_Click;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(3, 10);
        label5.Name = "label5";
        label5.Size = new Size(60, 15);
        label5.TabIndex = 5;
        label5.Text = "Username";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(6, 39);
        label6.Name = "label6";
        label6.Size = new Size(57, 15);
        label6.TabIndex = 6;
        label6.Text = "Password";
        // 
        // change_username
        // 
        change_username.BorderStyle = BorderStyle.FixedSingle;
        change_username.Location = new Point(69, 8);
        change_username.Name = "change_username";
        change_username.Size = new Size(174, 23);
        change_username.TabIndex = 3;
        // 
        // change_password
        // 
        change_password.BorderStyle = BorderStyle.FixedSingle;
        change_password.Location = new Point(69, 37);
        change_password.Name = "change_password";
        change_password.Size = new Size(174, 23);
        change_password.TabIndex = 4;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(3, 10);
        label3.Name = "label3";
        label3.Size = new Size(60, 15);
        label3.TabIndex = 5;
        label3.Text = "Username";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(6, 39);
        label4.Name = "label4";
        label4.Size = new Size(57, 15);
        label4.TabIndex = 6;
        label4.Text = "Password";
        // 
        // create_username
        // 
        create_username.BorderStyle = BorderStyle.FixedSingle;
        create_username.Location = new Point(69, 8);
        create_username.Name = "create_username";
        create_username.Size = new Size(174, 23);
        create_username.TabIndex = 3;
        // 
        // create_password
        // 
        create_password.BorderStyle = BorderStyle.FixedSingle;
        create_password.Location = new Point(69, 37);
        create_password.Name = "create_password";
        create_password.Size = new Size(174, 23);
        create_password.TabIndex = 4;
        // 
        // pull_panel
        // 
        pull_panel.Controls.Add(label17);
        pull_panel.Controls.Add(push_panel);
        pull_panel.Controls.Add(pull_count);
        pull_panel.Controls.Add(label16);
        pull_panel.Controls.Add(pull_offset);
        pull_panel.Controls.Add(pull_button);
        pull_panel.Controls.Add(label14);
        pull_panel.Controls.Add(label15);
        pull_panel.Controls.Add(pull_username);
        pull_panel.Controls.Add(pull_password);
        pull_panel.Enabled = false;
        pull_panel.Location = new Point(197, 26);
        pull_panel.Name = "pull_panel";
        pull_panel.Size = new Size(246, 272);
        pull_panel.TabIndex = 12;
        pull_panel.Visible = false;
        // 
        // label17
        // 
        label17.AutoSize = true;
        label17.Location = new Point(26, 95);
        label17.Name = "label17";
        label17.Size = new Size(40, 15);
        label17.TabIndex = 11;
        label17.Text = "Count";
        // 
        // push_panel
        // 
        push_panel.Controls.Add(label22);
        push_panel.Controls.Add(push_responseid);
        push_panel.Controls.Add(label18);
        push_panel.Controls.Add(push_data);
        push_panel.Controls.Add(label19);
        push_panel.Controls.Add(push_destination);
        push_panel.Controls.Add(push_button);
        push_panel.Controls.Add(label20);
        push_panel.Controls.Add(label21);
        push_panel.Controls.Add(push_username);
        push_panel.Controls.Add(push_password);
        push_panel.Enabled = false;
        push_panel.Location = new Point(0, 0);
        push_panel.Name = "push_panel";
        push_panel.Size = new Size(246, 272);
        push_panel.TabIndex = 13;
        push_panel.Visible = false;
        // 
        // label22
        // 
        label22.AutoSize = true;
        label22.Location = new Point(-2, 124);
        label22.Name = "label22";
        label22.Size = new Size(68, 15);
        label22.TabIndex = 13;
        label22.Text = "ResponseID";
        // 
        // push_responseid
        // 
        push_responseid.BorderStyle = BorderStyle.FixedSingle;
        push_responseid.Location = new Point(69, 122);
        push_responseid.MaxLength = 10;
        push_responseid.Name = "push_responseid";
        push_responseid.PlaceholderText = "None";
        push_responseid.Size = new Size(174, 23);
        push_responseid.TabIndex = 12;
        push_responseid.KeyPress += TextBox_Only_Numbers;
        // 
        // label18
        // 
        label18.AutoSize = true;
        label18.Location = new Point(35, 95);
        label18.Name = "label18";
        label18.Size = new Size(31, 15);
        label18.TabIndex = 11;
        label18.Text = "Data";
        // 
        // push_data
        // 
        push_data.BorderStyle = BorderStyle.FixedSingle;
        push_data.Location = new Point(69, 93);
        push_data.Name = "push_data";
        push_data.Size = new Size(174, 23);
        push_data.TabIndex = 10;
        // 
        // label19
        // 
        label19.AutoSize = true;
        label19.Location = new Point(-1, 66);
        label19.Name = "label19";
        label19.Size = new Size(67, 15);
        label19.TabIndex = 9;
        label19.Text = "Destination";
        // 
        // push_destination
        // 
        push_destination.BorderStyle = BorderStyle.FixedSingle;
        push_destination.Location = new Point(69, 64);
        push_destination.MaxLength = 10;
        push_destination.Name = "push_destination";
        push_destination.Size = new Size(174, 23);
        push_destination.TabIndex = 8;
        // 
        // push_button
        // 
        push_button.Location = new Point(91, 151);
        push_button.Name = "push_button";
        push_button.Size = new Size(75, 23);
        push_button.TabIndex = 7;
        push_button.Text = "Отправить";
        push_button.UseVisualStyleBackColor = true;
        push_button.Click += push_button_Click;
        // 
        // label20
        // 
        label20.AutoSize = true;
        label20.Location = new Point(6, 10);
        label20.Name = "label20";
        label20.Size = new Size(60, 15);
        label20.TabIndex = 5;
        label20.Text = "Username";
        // 
        // label21
        // 
        label21.AutoSize = true;
        label21.Location = new Point(9, 39);
        label21.Name = "label21";
        label21.Size = new Size(57, 15);
        label21.TabIndex = 6;
        label21.Text = "Password";
        // 
        // push_username
        // 
        push_username.BorderStyle = BorderStyle.FixedSingle;
        push_username.Location = new Point(69, 8);
        push_username.MaxLength = 32;
        push_username.Name = "push_username";
        push_username.Size = new Size(174, 23);
        push_username.TabIndex = 3;
        // 
        // push_password
        // 
        push_password.BorderStyle = BorderStyle.FixedSingle;
        push_password.Location = new Point(69, 37);
        push_password.MaxLength = 256;
        push_password.Name = "push_password";
        push_password.Size = new Size(174, 23);
        push_password.TabIndex = 4;
        // 
        // pull_count
        // 
        pull_count.BorderStyle = BorderStyle.FixedSingle;
        pull_count.Location = new Point(69, 93);
        pull_count.MaxLength = 10;
        pull_count.Name = "pull_count";
        pull_count.PlaceholderText = "None";
        pull_count.Size = new Size(174, 23);
        pull_count.TabIndex = 10;
        pull_count.KeyPress += TextBox_Only_Numbers;
        // 
        // label16
        // 
        label16.AutoSize = true;
        label16.Location = new Point(27, 66);
        label16.Name = "label16";
        label16.Size = new Size(39, 15);
        label16.TabIndex = 9;
        label16.Text = "Offset";
        // 
        // pull_offset
        // 
        pull_offset.BorderStyle = BorderStyle.FixedSingle;
        pull_offset.Location = new Point(69, 64);
        pull_offset.MaxLength = 10;
        pull_offset.Name = "pull_offset";
        pull_offset.PlaceholderText = "None";
        pull_offset.Size = new Size(174, 23);
        pull_offset.TabIndex = 8;
        pull_offset.KeyPress += TextBox_Only_Numbers;
        // 
        // pull_button
        // 
        pull_button.Location = new Point(87, 122);
        pull_button.Name = "pull_button";
        pull_button.Size = new Size(75, 23);
        pull_button.TabIndex = 7;
        pull_button.Text = "Отправить";
        pull_button.UseVisualStyleBackColor = true;
        pull_button.Click += pull_button_Click;
        // 
        // label14
        // 
        label14.AutoSize = true;
        label14.Location = new Point(6, 10);
        label14.Name = "label14";
        label14.Size = new Size(60, 15);
        label14.TabIndex = 5;
        label14.Text = "Username";
        // 
        // label15
        // 
        label15.AutoSize = true;
        label15.Location = new Point(9, 39);
        label15.Name = "label15";
        label15.Size = new Size(57, 15);
        label15.TabIndex = 6;
        label15.Text = "Password";
        // 
        // pull_username
        // 
        pull_username.BorderStyle = BorderStyle.FixedSingle;
        pull_username.Location = new Point(69, 8);
        pull_username.MaxLength = 32;
        pull_username.Name = "pull_username";
        pull_username.Size = new Size(174, 23);
        pull_username.TabIndex = 3;
        // 
        // pull_password
        // 
        pull_password.BorderStyle = BorderStyle.FixedSingle;
        pull_password.Location = new Point(69, 37);
        pull_password.MaxLength = 256;
        pull_password.Name = "pull_password";
        pull_password.Size = new Size(174, 23);
        pull_password.TabIndex = 4;
        // 
        // clear_button
        // 
        clear_button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        clear_button.Location = new Point(365, 466);
        clear_button.Name = "clear_button";
        clear_button.Size = new Size(75, 23);
        clear_button.TabIndex = 9;
        clear_button.Text = "Очистить";
        clear_button.UseVisualStyleBackColor = true;
        clear_button.Click += clear_button_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(731, 501);
        Controls.Add(pull_panel);
        Controls.Add(clear_button);
        Controls.Add(create_panel);
        Controls.Add(auth_panel);
        Controls.Add(listBox1);
        Controls.Add(log_box);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        MinimumSize = new Size(747, 540);
        Name = "MainForm";
        Text = "Form1";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        auth_panel.ResumeLayout(false);
        auth_panel.PerformLayout();
        delete_panel.ResumeLayout(false);
        delete_panel.PerformLayout();
        create_panel.ResumeLayout(false);
        create_panel.PerformLayout();
        change_panel.ResumeLayout(false);
        change_panel.PerformLayout();
        flush_panel.ResumeLayout(false);
        flush_panel.PerformLayout();
        last_panel.ResumeLayout(false);
        last_panel.PerformLayout();
        pull_panel.ResumeLayout(false);
        pull_panel.PerformLayout();
        push_panel.ResumeLayout(false);
        push_panel.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MenuStrip menuStrip1;
    private ToolStripMenuItem toolStripMenuItem1;
    private ToolStripMenuItem aToolStripMenuItem;
    private ToolStripMenuItem bToolStripMenuItem;
    private RichTextBox log_box;
    private ListBox listBox1;
    private TextBox auth_username;
    private TextBox auth_password;
    private Label label1;
    private Label label2;
    private Panel auth_panel;
    private Button auth_submit;
    private Panel create_panel;
    private Button create_button;
    private Label label3;
    private Label label4;
    private TextBox create_username;
    private TextBox create_password;
    private Panel change_panel;
    private TextBox change_newpassword;
    private Label label7;
    private Button change_button;
    private Label label5;
    private Label label6;
    private TextBox change_username;
    private TextBox change_password;
    private Panel delete_panel;
    private Button delete_button;
    private Label label8;
    private Label label9;
    private TextBox delete_username;
    private TextBox delete_password;
    private Panel flush_panel;
    private Button flush_button;
    private Label label10;
    private Label label11;
    private TextBox flush_username;
    private TextBox flush_password;
    private Panel last_panel;
    private Button last_button;
    private Label label12;
    private Label label13;
    private TextBox last_username;
    private TextBox last_password;
    private Panel pull_panel;
    private Label label16;
    private TextBox pull_offset;
    private Button pull_button;
    private Label label14;
    private Label label15;
    private TextBox pull_username;
    private TextBox pull_password;
    private Label label17;
    private TextBox pull_count;
    private Button clear_button;
    private Panel push_panel;
    private Label label18;
    private TextBox push_data;
    private Label label19;
    private TextBox push_destination;
    private Button push_button;
    private Label label20;
    private Label label21;
    private TextBox push_username;
    private TextBox push_password;
    private Label label22;
    private TextBox push_responseid;
}
