namespace HW_Calculator
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            textBoxFirst = new TextBox();
            textBoxSecond = new TextBox();
            buttonCanculate = new Button();
            textBoxResult = new TextBox();
            comboBoxDo = new ComboBox();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // textBoxFirst
            // 
            textBoxFirst.Location = new Point(184, 133);
            textBoxFirst.Name = "textBoxFirst";
            textBoxFirst.Size = new Size(125, 27);
            textBoxFirst.TabIndex = 0;
            // 
            // textBoxSecond
            // 
            textBoxSecond.Location = new Point(444, 133);
            textBoxSecond.Name = "textBoxSecond";
            textBoxSecond.Size = new Size(125, 27);
            textBoxSecond.TabIndex = 1;
            // 
            // buttonCanculate
            // 
            buttonCanculate.Location = new Point(328, 166);
            buttonCanculate.Name = "buttonCanculate";
            buttonCanculate.Size = new Size(94, 29);
            buttonCanculate.TabIndex = 3;
            buttonCanculate.Text = "Canculate";
            buttonCanculate.UseVisualStyleBackColor = true;
            buttonCanculate.Click += buttonCanculate_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(313, 201);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(125, 27);
            textBoxResult.TabIndex = 4;
            // 
            // comboBoxDo
            // 
            comboBoxDo.FormattingEnabled = true;
            comboBoxDo.Items.AddRange(new object[] { "+", "-", "*", "/", "%", "^" });
            comboBoxDo.Location = new Point(358, 132);
            comboBoxDo.Name = "comboBoxDo";
            comboBoxDo.Size = new Size(40, 28);
            comboBoxDo.TabIndex = 5;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxDo);
            Controls.Add(textBoxResult);
            Controls.Add(buttonCanculate);
            Controls.Add(textBoxSecond);
            Controls.Add(textBoxFirst);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFirst;
        private TextBox textBoxSecond;
        private Button buttonCanculate;
        private TextBox textBoxResult;
        private ComboBox comboBoxDo;
        private System.Windows.Forms.Timer timer1;
    }
}