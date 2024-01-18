namespace SHRework.ToolClient;

static class Program {

    static MainForm Form;

    [STAThread]
    static void Main() {
        ApplicationConfiguration.Initialize();

        Form = new MainForm();
        Form.ConfigManager.LoadConfig();
        Application.Run(Form);
    }    
}