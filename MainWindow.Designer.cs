namespace MassImageEditor;

partial class MainWindow
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        SettingsButton = new System.Windows.Forms.Button();
        WelcomeSign = new System.Windows.Forms.TextBox();
        InputButton = new System.Windows.Forms.Button();
        OutputButton = new System.Windows.Forms.Button();
        Images = new System.Windows.Forms.ListView();
        File_name = new System.Windows.Forms.ColumnHeader();
        Status = new System.Windows.Forms.ColumnHeader();
        Progress = new System.Windows.Forms.ColumnHeader();
        Message = new System.Windows.Forms.ColumnHeader();
        SuspendLayout();
        //
        // SettingsButton
        //
        SettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)128)), ((int)((byte)128)));
        SettingsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        SettingsButton.Location = new System.Drawing.Point(13, 383);
        SettingsButton.Name = "SettingsButton";
        SettingsButton.Size = new System.Drawing.Size(198, 58);
        SettingsButton.TabIndex = 0;
        SettingsButton.Text = "Settings";
        SettingsButton.UseVisualStyleBackColor = false;
        //
        // WelcomeSign
        //
        WelcomeSign.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        WelcomeSign.Location = new System.Drawing.Point(219, 12);
        WelcomeSign.Name = "WelcomeSign";
        WelcomeSign.ReadOnly = true;
        WelcomeSign.Size = new System.Drawing.Size(378, 43);
        WelcomeSign.TabIndex = 1;
        WelcomeSign.Text = "Welcome to mass image editor";
        WelcomeSign.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        //
        // InputButton
        //
        InputButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
        InputButton.Location = new System.Drawing.Point(22, 97);
        InputButton.Name = "InputButton";
        InputButton.Size = new System.Drawing.Size(189, 58);
        InputButton.TabIndex = 2;
        InputButton.Text = "Choose folder with images ...";
        InputButton.UseVisualStyleBackColor = false;
        //
        // OutputButton
        //
        OutputButton.BackColor = System.Drawing.Color.YellowGreen;
        OutputButton.Location = new System.Drawing.Point(237, 97);
        OutputButton.Name = "OutputButton";
        OutputButton.Size = new System.Drawing.Size(189, 58);
        OutputButton.TabIndex = 3;
        OutputButton.Text = "Choose folder to output the processed images.";
        OutputButton.UseVisualStyleBackColor = false;
        //
        // Images
        //
        Images.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { File_name, Status, Progress, Message });
        Images.GridLines = true;
        Images.Location = new System.Drawing.Point(457, 104);
        Images.Name = "Images";
        Images.Size = new System.Drawing.Size(597, 504);
        Images.TabIndex = 4;
        Images.UseCompatibleStateImageBehavior = false;
        //
        // File name
        //
        File_name.Name = "File name";
        File_name.Width = 250;
        //
        // Status
        //
        Status.Name = "Status";
        Status.Width = 250;
        //
        // Progress
        //
        Progress.Name = "Progress";
        //
        // Message
        //
        Message.Name = "Message";
        Message.Width = 250;
        // 
        // MainWindow
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1068, 622);
        Controls.Add(Images);
        Controls.Add(OutputButton);
        Controls.Add(InputButton);
        Controls.Add(WelcomeSign);
        Controls.Add(SettingsButton);
        Text = "Mass image editor";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ColumnHeader Status;
    private System.Windows.Forms.ColumnHeader Progress;
    private System.Windows.Forms.ColumnHeader File_name;
    private System.Windows.Forms.ColumnHeader Message;

    private System.Windows.Forms.ListView Images;

    private System.Windows.Forms.Button OutputButton;

    private System.Windows.Forms.Button InputButton;

    private System.Windows.Forms.TextBox WelcomeSign;

    private System.Windows.Forms.Button SettingsButton;

    #endregion
}