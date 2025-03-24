﻿namespace hijri_calendar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dateLabel = new System.Windows.Forms.Label();
            this.Hijri = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.shortcutStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.enableStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.disableStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.textSizeList = new System.Windows.Forms.ToolStripMenuItem();
            this.textSize8px = new System.Windows.Forms.ToolStripMenuItem();
            this.textSize10px = new System.Windows.Forms.ToolStripMenuItem();
            this.textSize12px = new System.Windows.Forms.ToolStripMenuItem();
            this.textSize14px = new System.Windows.Forms.ToolStripMenuItem();
            this.textSize16px = new System.Windows.Forms.ToolStripMenuItem();
            this.textSize18px = new System.Windows.Forms.ToolStripMenuItem();
            this.textSize20px = new System.Windows.Forms.ToolStripMenuItem();
            this.textColorList = new System.Windows.Forms.ToolStripMenuItem();
            this.textColorBlack = new System.Windows.Forms.ToolStripMenuItem();
            this.textColorWhite = new System.Windows.Forms.ToolStripMenuItem();
            this.textColorRed = new System.Windows.Forms.ToolStripMenuItem();
            this.textColorGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.textColorLime = new System.Windows.Forms.ToolStripMenuItem();
            this.textColorBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.textColorLightBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.textColorYellow = new System.Windows.Forms.ToolStripMenuItem();
            this.textColorCyan = new System.Windows.Forms.ToolStripMenuItem();
            this.textColorMagenta = new System.Windows.Forms.ToolStripMenuItem();
            this.showMonthNameStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.closeStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.languageList = new System.Windows.Forms.ToolStripMenuItem();
            this.arabicStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.englishStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Tahoma", 16F);
            this.dateLabel.Location = new System.Drawing.Point(0, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 27);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Hijri
            // 
            this.Hijri.ContextMenuStrip = this.contextMenuStrip1;
            this.Hijri.Icon = ((System.Drawing.Icon)(resources.GetObject("Hijri.Icon")));
            this.Hijri.Text = "Hijri Calendar";
            this.Hijri.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shortcutStrip,
            this.textSizeList,
            this.textColorList,
            this.languageList,
            this.showMonthNameStrip,
            this.updateStrip,
            this.closeStrip});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(195, 180);
            this.contextMenuStrip1.Text = "القائمة";
            // 
            // shortcutStrip
            // 
            this.shortcutStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableStrip,
            this.disableStrip});
            this.shortcutStrip.Name = "shortcutStrip";
            this.shortcutStrip.Size = new System.Drawing.Size(194, 22);
            this.shortcutStrip.Text = "التشغيل عند بدء الويندوز";
            // 
            // enableStrip
            // 
            this.enableStrip.Name = "enableStrip";
            this.enableStrip.Size = new System.Drawing.Size(107, 22);
            this.enableStrip.Text = "تفعيل";
            // 
            // disableStrip
            // 
            this.disableStrip.Name = "disableStrip";
            this.disableStrip.Size = new System.Drawing.Size(107, 22);
            this.disableStrip.Text = "تعطيل";
            // 
            // textSizeList
            // 
            this.textSizeList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textSize8px,
            this.textSize10px,
            this.textSize12px,
            this.textSize14px,
            this.textSize16px,
            this.textSize18px,
            this.textSize20px});
            this.textSizeList.Name = "textSizeList";
            this.textSizeList.Size = new System.Drawing.Size(194, 22);
            this.textSizeList.Text = "حجم الخط";
            // 
            // textSize8px
            // 
            this.textSize8px.Name = "textSize8px";
            this.textSize8px.Size = new System.Drawing.Size(102, 22);
            this.textSize8px.Text = "8 px";
            // 
            // textSize10px
            // 
            this.textSize10px.Name = "textSize10px";
            this.textSize10px.Size = new System.Drawing.Size(102, 22);
            this.textSize10px.Text = "10 px";
            // 
            // textSize12px
            // 
            this.textSize12px.Name = "textSize12px";
            this.textSize12px.Size = new System.Drawing.Size(102, 22);
            this.textSize12px.Text = "12 px";
            // 
            // textSize14px
            // 
            this.textSize14px.Name = "textSize14px";
            this.textSize14px.Size = new System.Drawing.Size(102, 22);
            this.textSize14px.Text = "14 px";
            // 
            // textSize16px
            // 
            this.textSize16px.Name = "textSize16px";
            this.textSize16px.Size = new System.Drawing.Size(102, 22);
            this.textSize16px.Text = "16 px";
            // 
            // textSize18px
            // 
            this.textSize18px.Name = "textSize18px";
            this.textSize18px.Size = new System.Drawing.Size(102, 22);
            this.textSize18px.Text = "18 px";
            // 
            // textSize20px
            // 
            this.textSize20px.Name = "textSize20px";
            this.textSize20px.Size = new System.Drawing.Size(102, 22);
            this.textSize20px.Text = "20 px";
            // 
            // textColorList
            // 
            this.textColorList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textColorBlack,
            this.textColorWhite,
            this.textColorRed,
            this.textColorGreen,
            this.textColorLime,
            this.textColorBlue,
            this.textColorLightBlue,
            this.textColorYellow,
            this.textColorCyan,
            this.textColorMagenta});
            this.textColorList.Name = "textColorList";
            this.textColorList.Size = new System.Drawing.Size(194, 22);
            this.textColorList.Text = "لون الخط";
            // 
            // textColorBlack
            // 
            this.textColorBlack.Name = "textColorBlack";
            this.textColorBlack.Size = new System.Drawing.Size(118, 22);
            this.textColorBlack.Text = "أسود";
            // 
            // textColorWhite
            // 
            this.textColorWhite.Name = "textColorWhite";
            this.textColorWhite.Size = new System.Drawing.Size(118, 22);
            this.textColorWhite.Text = "أبيض";
            // 
            // textColorRed
            // 
            this.textColorRed.Name = "textColorRed";
            this.textColorRed.Size = new System.Drawing.Size(118, 22);
            this.textColorRed.Text = "أحمر";
            // 
            // textColorGreen
            // 
            this.textColorGreen.Name = "textColorGreen";
            this.textColorGreen.Size = new System.Drawing.Size(118, 22);
            this.textColorGreen.Text = "أخضر";
            // 
            // textColorLime
            // 
            this.textColorLime.Name = "textColorLime";
            this.textColorLime.Size = new System.Drawing.Size(118, 22);
            this.textColorLime.Text = "ليموني";
            // 
            // textColorBlue
            // 
            this.textColorBlue.Name = "textColorBlue";
            this.textColorBlue.Size = new System.Drawing.Size(118, 22);
            this.textColorBlue.Text = "أزرق";
            // 
            // textColorLightBlue
            // 
            this.textColorLightBlue.Name = "textColorLightBlue";
            this.textColorLightBlue.Size = new System.Drawing.Size(118, 22);
            this.textColorLightBlue.Text = "أزرق فاتح";
            // 
            // textColorYellow
            // 
            this.textColorYellow.Name = "textColorYellow";
            this.textColorYellow.Size = new System.Drawing.Size(118, 22);
            this.textColorYellow.Text = "أصفر";
            // 
            // textColorCyan
            // 
            this.textColorCyan.Name = "textColorCyan";
            this.textColorCyan.Size = new System.Drawing.Size(118, 22);
            this.textColorCyan.Text = "سماوي";
            // 
            // textColorMagenta
            // 
            this.textColorMagenta.Name = "textColorMagenta";
            this.textColorMagenta.Size = new System.Drawing.Size(118, 22);
            this.textColorMagenta.Text = "قرمزي";
            // 
            // showMonthNameStrip
            // 
            this.showMonthNameStrip.Name = "showMonthNameStrip";
            this.showMonthNameStrip.Size = new System.Drawing.Size(194, 22);
            this.showMonthNameStrip.Text = "إخفاء إسم الشهر";
            // 
            // updateStrip
            // 
            this.updateStrip.Name = "updateStrip";
            this.updateStrip.Size = new System.Drawing.Size(194, 22);
            this.updateStrip.Text = "تحديث التاريخ";
            // 
            // closeStrip
            // 
            this.closeStrip.Name = "closeStrip";
            this.closeStrip.Size = new System.Drawing.Size(194, 22);
            this.closeStrip.Text = "خروج";
            // 
            // languageList
            // 
            this.languageList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arabicStrip,
            this.englishStrip});
            this.languageList.Name = "languageList";
            this.languageList.Size = new System.Drawing.Size(194, 22);
            this.languageList.Text = "اللغة";
            // 
            // arabicStrip
            // 
            this.arabicStrip.Name = "arabicStrip";
            this.arabicStrip.Size = new System.Drawing.Size(112, 22);
            this.arabicStrip.Text = "العربية";
            // 
            // englishStrip
            // 
            this.englishStrip.Name = "englishStrip";
            this.englishStrip.Size = new System.Drawing.Size(112, 22);
            this.englishStrip.Text = "English";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(147, 56);
            this.Controls.Add(this.dateLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Hijri Calendar";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.NotifyIcon Hijri;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem shortcutStrip;
        private System.Windows.Forms.ToolStripMenuItem closeStrip;
        private System.Windows.Forms.ToolStripMenuItem enableStrip;
        private System.Windows.Forms.ToolStripMenuItem disableStrip;
        private System.Windows.Forms.ToolStripMenuItem updateStrip;
        private System.Windows.Forms.ToolStripMenuItem textSizeList;
        private System.Windows.Forms.ToolStripMenuItem textColorList;
        private System.Windows.Forms.ToolStripMenuItem textSize8px;
        private System.Windows.Forms.ToolStripMenuItem textSize10px;
        private System.Windows.Forms.ToolStripMenuItem textSize12px;
        private System.Windows.Forms.ToolStripMenuItem textSize16px;
        private System.Windows.Forms.ToolStripMenuItem textSize20px;
        private System.Windows.Forms.ToolStripMenuItem textColorBlack;
        private System.Windows.Forms.ToolStripMenuItem textColorWhite;
        private System.Windows.Forms.ToolStripMenuItem textColorRed;
        private System.Windows.Forms.ToolStripMenuItem textColorGreen;
        private System.Windows.Forms.ToolStripMenuItem textColorLime;
        private System.Windows.Forms.ToolStripMenuItem textColorBlue;
        private System.Windows.Forms.ToolStripMenuItem textColorLightBlue;
        private System.Windows.Forms.ToolStripMenuItem textColorYellow;
        private System.Windows.Forms.ToolStripMenuItem textColorCyan;
        private System.Windows.Forms.ToolStripMenuItem textColorMagenta;
        private System.Windows.Forms.ToolStripMenuItem textSize14px;
        private System.Windows.Forms.ToolStripMenuItem textSize18px;
        private System.Windows.Forms.ToolStripMenuItem showMonthNameStrip;
        private System.Windows.Forms.ToolStripMenuItem languageList;
        private System.Windows.Forms.ToolStripMenuItem arabicStrip;
        private System.Windows.Forms.ToolStripMenuItem englishStrip;
    }
}

