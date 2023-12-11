namespace OnlineLearningManagementSytem
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            label1 = new Label();
            profilePictureBox = new PictureBox();
            uploadPhotoButton = new Button();
            emailTextBox = new TextBox();
            emailLabel = new Label();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            loginButton = new Button();
            titleLabel = new Label();
            LoginLinkLabel = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(502, 369);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 27);
            textBox1.TabIndex = 21;
            // 
            // label1
            // 
            label1.Location = new Point(502, 340);
            label1.Name = "label1";
            label1.Size = new Size(114, 31);
            label1.TabIndex = 22;
            label1.Text = "User Name *";
            // 
            // profilePictureBox
            // 
            profilePictureBox.Location = new Point(13, 15);
            profilePictureBox.Margin = new Padding(3, 4, 3, 4);
            profilePictureBox.Name = "profilePictureBox";
            profilePictureBox.Size = new Size(171, 200);
            profilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            profilePictureBox.TabIndex = 15;
            profilePictureBox.TabStop = false;
            // 
            // uploadPhotoButton
            // 
            uploadPhotoButton.Location = new Point(218, 68);
            uploadPhotoButton.Margin = new Padding(3, 4, 3, 4);
            uploadPhotoButton.Name = "uploadPhotoButton";
            uploadPhotoButton.Size = new Size(137, 40);
            uploadPhotoButton.TabIndex = 16;
            uploadPhotoButton.Text = "Upload Photo";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(502, 232);
            emailTextBox.Margin = new Padding(3, 4, 3, 4);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(238, 27);
            emailTextBox.TabIndex = 17;
            // 
            // emailLabel
            // 
            emailLabel.Location = new Point(502, 203);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(114, 31);
            emailLabel.TabIndex = 19;
            emailLabel.Text = "Email *";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(502, 301);
            passwordTextBox.Margin = new Padding(3, 4, 3, 4);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(238, 27);
            passwordTextBox.TabIndex = 18;
            // 
            // passwordLabel
            // 
            passwordLabel.Location = new Point(502, 272);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(114, 31);
            passwordLabel.TabIndex = 20;
            passwordLabel.Text = "Password *";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(557, 420);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(116, 39);
            loginButton.TabIndex = 23;
            loginButton.Text = "Sign Up";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.Location = new Point(550, 131);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(123, 37);
            titleLabel.TabIndex = 24;
            titleLabel.Text = "Register";
            // 
            // LoginLinkLabel
            // 
            LoginLinkLabel.Location = new Point(550, 481);
            LoginLinkLabel.Name = "LoginLinkLabel";
            LoginLinkLabel.Size = new Size(153, 31);
            LoginLinkLabel.TabIndex = 25;
            LoginLinkLabel.TabStop = true;
            LoginLinkLabel.Text = "Go To Login Page";
            LoginLinkLabel.LinkClicked += LoginLinkLabel_LinkClicked;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 707);
            Controls.Add(LoginLinkLabel);
            Controls.Add(titleLabel);
            Controls.Add(loginButton);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(profilePictureBox);
            Controls.Add(uploadPhotoButton);
            Controls.Add(emailTextBox);
            Controls.Add(emailLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegistrationForm";
            Text = "RegistrartionForm";
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private PictureBox profilePictureBox;
        private Button uploadPhotoButton;
        private TextBox emailTextBox;
        private Label emailLabel;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private Button loginButton;
        private Label titleLabel;
        private LinkLabel LoginLinkLabel;
    }
}