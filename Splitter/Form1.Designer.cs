
namespace Splitter
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.input_textbox = new System.Windows.Forms.TextBox();
            this.split_button = new System.Windows.Forms.Button();
            this.display_listbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // input_textbox
            // 
            this.input_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.input_textbox.Location = new System.Drawing.Point(12, 12);
            this.input_textbox.Multiline = true;
            this.input_textbox.Name = "input_textbox";
            this.input_textbox.Size = new System.Drawing.Size(235, 292);
            this.input_textbox.TabIndex = 0;
            // 
            // split_button
            // 
            this.split_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.split_button.Location = new System.Drawing.Point(89, 314);
            this.split_button.Name = "split_button";
            this.split_button.Size = new System.Drawing.Size(75, 40);
            this.split_button.TabIndex = 1;
            this.split_button.Text = "Split";
            this.split_button.UseVisualStyleBackColor = true;
            this.split_button.Click += new System.EventHandler(this.split_button_Click);
            // 
            // display_listbox
            // 
            this.display_listbox.FormattingEnabled = true;
            this.display_listbox.ItemHeight = 16;
            this.display_listbox.Location = new System.Drawing.Point(253, 12);
            this.display_listbox.Name = "display_listbox";
            this.display_listbox.Size = new System.Drawing.Size(240, 292);
            this.display_listbox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 363);
            this.Controls.Add(this.display_listbox);
            this.Controls.Add(this.split_button);
            this.Controls.Add(this.input_textbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_textbox;
        private System.Windows.Forms.Button split_button;
        private System.Windows.Forms.ListBox display_listbox;
    }
}

