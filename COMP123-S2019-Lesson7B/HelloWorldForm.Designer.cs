namespace COMP123_S2019_Lesson7B
{
    partial class Form1
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
            this.HelloWorldlabel = new System.Windows.Forms.Label();
            this.ClickMebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HelloWorldlabel
            // 
            this.HelloWorldlabel.BackColor = System.Drawing.Color.White;
            this.HelloWorldlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HelloWorldlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelloWorldlabel.Location = new System.Drawing.Point(235, 225);
            this.HelloWorldlabel.Name = "HelloWorldlabel";
            this.HelloWorldlabel.Size = new System.Drawing.Size(187, 43);
            this.HelloWorldlabel.TabIndex = 0;
            this.HelloWorldlabel.Text = "Hello,World!!!";
            // 
            // ClickMebutton
            // 
            this.ClickMebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClickMebutton.Location = new System.Drawing.Point(74, 225);
            this.ClickMebutton.Name = "ClickMebutton";
            this.ClickMebutton.Size = new System.Drawing.Size(142, 43);
            this.ClickMebutton.TabIndex = 1;
            this.ClickMebutton.Text = "Click Me!";
            this.ClickMebutton.UseVisualStyleBackColor = true;
            this.ClickMebutton.Click += new System.EventHandler(this.ClickMebutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.ClickMebutton);
            this.Controls.Add(this.HelloWorldlabel);
            this.Name = "Form1";
            this.Text = "HelloWorld";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HelloWorldlabel;
        private System.Windows.Forms.Button ClickMebutton;
    }
}

