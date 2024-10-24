namespace LAB_7_BUTOK
{
    partial class Form_Point_Kinematics
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
        private void InitializeComponent()
        {
            VelocityButoon = new Button();
            Acceleration_Button = new Button();
            Exit_Butoon = new Button();
            hScrollBarA = new HScrollBar();
            hScrollBarB = new HScrollBar();
            Acceleration_textBox = new TextBox();
            Velocity_textBox = new TextBox();
            Main_Text = new Label();
            Lable_form2 = new Label();
            Lable_form1 = new Label();
            labelA = new Label();
            labelB = new Label();
            SuspendLayout();
            // 
            // VelocityButoon
            // 
            VelocityButoon.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            VelocityButoon.Location = new Point(12, 154);
            VelocityButoon.Name = "VelocityButoon";
            VelocityButoon.Size = new Size(153, 34);
            VelocityButoon.TabIndex = 0;
            VelocityButoon.Text = "Швидкість";
            VelocityButoon.UseVisualStyleBackColor = true;
            VelocityButoon.Click += VelocityButoon_Click;
            // 
            // Acceleration_Button
            // 
            Acceleration_Button.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Acceleration_Button.Location = new Point(12, 222);
            Acceleration_Button.Name = "Acceleration_Button";
            Acceleration_Button.Size = new Size(153, 36);
            Acceleration_Button.TabIndex = 1;
            Acceleration_Button.Text = "Прискорення ";
            Acceleration_Button.UseVisualStyleBackColor = true;
            Acceleration_Button.Click += Acceleration_Button_Click;
            // 
            // Exit_Butoon
            // 
            Exit_Butoon.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Exit_Butoon.Location = new Point(672, 490);
            Exit_Butoon.Name = "Exit_Butoon";
            Exit_Butoon.Size = new Size(94, 47);
            Exit_Butoon.TabIndex = 2;
            Exit_Butoon.Text = "Вихід";
            Exit_Butoon.UseVisualStyleBackColor = true;
            Exit_Butoon.Click += Exit_Butoon_Click;
            // 
            // hScrollBarA
            // 
            hScrollBarA.Location = new Point(182, 333);
            hScrollBarA.Minimum = 1;
            hScrollBarA.Name = "hScrollBarA";
            hScrollBarA.Size = new Size(567, 26);
            hScrollBarA.TabIndex = 3;
            hScrollBarA.Value = 1;
            hScrollBarA.Scroll += hScrollBarA_Scroll;
            // 
            // hScrollBarB
            // 
            hScrollBarB.Location = new Point(182, 422);
            hScrollBarB.Minimum = 1;
            hScrollBarB.Name = "hScrollBarB";
            hScrollBarB.Size = new Size(567, 26);
            hScrollBarB.TabIndex = 4;
            hScrollBarB.Value = 1;
            hScrollBarB.Scroll += hScrollBarA_Scroll;
            // 
            // Acceleration_textBox
            // 
            Acceleration_textBox.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Acceleration_textBox.Location = new Point(182, 224);
            Acceleration_textBox.Name = "Acceleration_textBox";
            Acceleration_textBox.ReadOnly = true;
            Acceleration_textBox.Size = new Size(567, 34);
            Acceleration_textBox.TabIndex = 5;
            // 
            // Velocity_textBox
            // 
            Velocity_textBox.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Velocity_textBox.Location = new Point(182, 154);
            Velocity_textBox.Name = "Velocity_textBox";
            Velocity_textBox.ReadOnly = true;
            Velocity_textBox.Size = new Size(567, 34);
            Velocity_textBox.TabIndex = 6;
            // 
            // Main_Text
            // 
            Main_Text.AutoSize = true;
            Main_Text.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Main_Text.Location = new Point(332, 9);
            Main_Text.Name = "Main_Text";
            Main_Text.Size = new Size(133, 27);
            Main_Text.TabIndex = 7;
            Main_Text.Text = "Закон руху";
            // 
            // Lable_form2
            // 
            Lable_form2.AutoSize = true;
            Lable_form2.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Lable_form2.Location = new Point(296, 92);
            Lable_form2.Name = "Lable_form2";
            Lable_form2.Size = new Size(205, 27);
            Lable_form2.TabIndex = 8;
            Lable_form2.Text = "y = a*b*sin(pi*b*t)";
            // 
            // Lable_form1
            // 
            Lable_form1.AutoSize = true;
            Lable_form1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Lable_form1.Location = new Point(296, 49);
            Lable_form1.Name = "Lable_form1";
            Lable_form1.Size = new Size(211, 27);
            Lable_form1.TabIndex = 9;
            Lable_form1.Text = "x = a*b*cos(pi*b*t)";
            // 
            // labelA
            // 
            labelA.AutoSize = true;
            labelA.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelA.Location = new Point(423, 306);
            labelA.Name = "labelA";
            labelA.Size = new Size(29, 27);
            labelA.TabIndex = 10;
            labelA.Text = "A";
            // 
            // labelB
            // 
            labelB.AutoSize = true;
            labelB.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelB.Location = new Point(423, 395);
            labelB.Name = "labelB";
            labelB.Size = new Size(29, 27);
            labelB.TabIndex = 11;
            labelB.Text = "B";
            // 
            // Form_Point_Kinematics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Violet;
            ClientSize = new Size(778, 549);
            Controls.Add(labelB);
            Controls.Add(labelA);
            Controls.Add(Lable_form1);
            Controls.Add(Lable_form2);
            Controls.Add(Main_Text);
            Controls.Add(Velocity_textBox);
            Controls.Add(Acceleration_textBox);
            Controls.Add(hScrollBarB);
            Controls.Add(hScrollBarA);
            Controls.Add(Exit_Butoon);
            Controls.Add(Acceleration_Button);
            Controls.Add(VelocityButoon);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_Point_Kinematics";
            Text = "Кінематика точки";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button VelocityButoon;
        private Button Acceleration_Button;
        private Button Exit_Butoon;
        private HScrollBar hScrollBarA;
        private HScrollBar hScrollBarB;
        private TextBox Acceleration_textBox;
        private TextBox Velocity_textBox;
        private Label Main_Text;
        private Label Lable_form2;
        private Label Lable_form1;
        private Label labelA;
        private Label labelB;
    }
}
