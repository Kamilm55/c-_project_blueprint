namespace OnlineLearningManagementSytem
{
    partial class Form1
    {
        // Other auto-generated code...

        // Add the following code for the login form
        private void InitializeComponent()
        {
            titleLabel = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            usernameLabel = new Label();
            passwordLabel = new Label();
            loginButton = new Button();
            registerLinkLabel = new LinkLabel();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.Location = new Point(370, 70);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(465, 37);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Welcome to Our Learning Platform";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(466, 168);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(209, 27);
            usernameTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(466, 222);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(209, 27);
            passwordTextBox.TabIndex = 2;
            // 
            // usernameLabel
            // 
            usernameLabel.Location = new Point(466, 142);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(100, 23);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Email";
            // 
            // passwordLabel
            // 
            passwordLabel.Location = new Point(466, 198);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(100, 23);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password";
            passwordLabel.Click += passwordLabel_Click;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(501, 267);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(116, 39);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            // 
            // registerLinkLabel
            // 
            registerLinkLabel.Location = new Point(456, 322);
            registerLinkLabel.Name = "registerLinkLabel";
            registerLinkLabel.Size = new Size(235, 31);
            registerLinkLabel.TabIndex = 6;
            registerLinkLabel.TabStop = true;
            registerLinkLabel.Text = "Don't have an account? Register";
            registerLinkLabel.LinkClicked += registerLinkLabel_LinkClicked;
            // 
            // Form1
            // 
            ClientSize = new Size(1297, 687);
            Controls.Add(titleLabel);
            Controls.Add(usernameTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameLabel);
            Controls.Add(passwordLabel);
            Controls.Add(loginButton);
            Controls.Add(registerLinkLabel);
            Name = "Form1";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label titleLabel;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Label usernameLabel;
        private Label passwordLabel;
        private Button loginButton;
        private LinkLabel registerLinkLabel;

        // ... Event handler for registration link
        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open the registration form or switch to the registration tab/page
            // Example: Open a new form for registration
            using (var registrationForm = new RegistrationForm())
            {
                // Hide the current form
                this.Hide();
                registrationForm.ShowDialog();
            }
        }
    }

}