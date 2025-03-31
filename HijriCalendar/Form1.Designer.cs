using System.Drawing;

namespace hijri_calendar
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
            this.languageList = new System.Windows.Forms.ToolStripMenuItem();
            this.arabicStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.englishStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.formPositionsList = new System.Windows.Forms.ToolStripMenuItem();
            this.leftTopStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.rightTopStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.leftBottomStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.rightBottomStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.formOpacityList = new System.Windows.Forms.ToolStripMenuItem();
            this.opacity50Strip = new System.Windows.Forms.ToolStripMenuItem();
            this.opacity60Strip = new System.Windows.Forms.ToolStripMenuItem();
            this.opacity70Strip = new System.Windows.Forms.ToolStripMenuItem();
            this.opacity80Strip = new System.Windows.Forms.ToolStripMenuItem();
            this.opacity90Strip = new System.Windows.Forms.ToolStripMenuItem();
            this.opacity100Strip = new System.Windows.Forms.ToolStripMenuItem();
            this.showMonthNameStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.progLinkStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.closeStrip = new System.Windows.Forms.ToolStripMenuItem();
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
            this.formPositionsList,
            this.formOpacityList,
            this.showMonthNameStrip,
            this.updateStrip,
            this.progLinkStrip,
            this.closeStrip});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(195, 246);
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
            this.textSize8px.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textSize8px.Size = new System.Drawing.Size(180, 22);
            this.textSize8px.Tag = 8f;
            this.textSize8px.Text = "8px";
            // 
            // textSize10px
            // 
            this.textSize10px.Name = "textSize10px";
            this.textSize10px.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textSize10px.Size = new System.Drawing.Size(180, 22);
            this.textSize10px.Tag = 10f;
            this.textSize10px.Text = "10px";
            // 
            // textSize12px
            // 
            this.textSize12px.Name = "textSize12px";
            this.textSize12px.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textSize12px.Size = new System.Drawing.Size(180, 22);
            this.textSize12px.Tag = 12f;
            this.textSize12px.Text = "12px";
            // 
            // textSize14px
            // 
            this.textSize14px.Name = "textSize14px";
            this.textSize14px.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textSize14px.Size = new System.Drawing.Size(180, 22);
            this.textSize14px.Tag = 14f;
            this.textSize14px.Text = "14px";
            // 
            // textSize16px
            // 
            this.textSize16px.Name = "textSize16px";
            this.textSize16px.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textSize16px.Size = new System.Drawing.Size(180, 22);
            this.textSize16px.Tag = 16f;
            this.textSize16px.Text = "16px";
            // 
            // textSize18px
            // 
            this.textSize18px.Name = "textSize18px";
            this.textSize18px.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textSize18px.Size = new System.Drawing.Size(180, 22);
            this.textSize18px.Tag = 18f;
            this.textSize18px.Text = "18px";
            // 
            // textSize20px
            // 
            this.textSize20px.Name = "textSize20px";
            this.textSize20px.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textSize20px.Size = new System.Drawing.Size(180, 22);
            this.textSize20px.Tag = 20f;
            this.textSize20px.Text = "20px";
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
            textColorBlack.Tag = Color.Black;
            // 
            // textColorWhite
            // 
            this.textColorWhite.Name = "textColorWhite";
            this.textColorWhite.Size = new System.Drawing.Size(118, 22);
            this.textColorWhite.Text = "أبيض";
            textColorWhite.Tag = Color.White;
            // 
            // textColorRed
            // 
            this.textColorRed.Name = "textColorRed";
            this.textColorRed.Size = new System.Drawing.Size(118, 22);
            this.textColorRed.Text = "أحمر";
            textColorRed.Tag = Color.Red;
            // 
            // textColorGreen
            // 
            this.textColorGreen.Name = "textColorGreen";
            this.textColorGreen.Size = new System.Drawing.Size(118, 22);
            this.textColorGreen.Text = "أخضر";
            textColorGreen.Tag = Color.Green;
            // 
            // textColorLime
            // 
            this.textColorLime.Name = "textColorLime";
            this.textColorLime.Size = new System.Drawing.Size(118, 22);
            this.textColorLime.Text = "ليموني";
            textColorLime.Tag = Color.Lime;
            // 
            // textColorBlue
            // 
            this.textColorBlue.Name = "textColorBlue";
            this.textColorBlue.Size = new System.Drawing.Size(118, 22);
            this.textColorBlue.Text = "أزرق";
            textColorBlue.Tag = Color.Blue;
            // 
            // textColorLightBlue
            // 
            this.textColorLightBlue.Name = "textColorLightBlue";
            this.textColorLightBlue.Size = new System.Drawing.Size(118, 22);
            this.textColorLightBlue.Text = "أزرق فاتح";
            textColorLightBlue.Tag = Color.FromArgb(50, 100, 255);
            // 
            // textColorYellow
            // 
            this.textColorYellow.Name = "textColorYellow";
            this.textColorYellow.Size = new System.Drawing.Size(118, 22);
            this.textColorYellow.Text = "أصفر";
            textColorYellow.Tag = Color.Yellow;
            // 
            // textColorCyan
            // 
            this.textColorCyan.Name = "textColorCyan";
            this.textColorCyan.Size = new System.Drawing.Size(118, 22);
            this.textColorCyan.Text = "سماوي";
            textColorCyan.Tag = Color.Cyan;
            // 
            // textColorMagenta
            // 
            this.textColorMagenta.Name = "textColorMagenta";
            this.textColorMagenta.Size = new System.Drawing.Size(118, 22);
            this.textColorMagenta.Text = "قرمزي";
            textColorMagenta.Tag = Color.Magenta;
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
            arabicStrip.Tag = 0;
            // 
            // englishStrip
            // 
            this.englishStrip.Name = "englishStrip";
            this.englishStrip.Size = new System.Drawing.Size(112, 22);
            this.englishStrip.Text = "English";
            englishStrip.Tag = 1;
            // 
            // formPositionsList
            // 
            this.formPositionsList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftTopStrip,
            this.rightTopStrip,
            this.leftBottomStrip,
            this.rightBottomStrip});
            this.formPositionsList.Name = "formPositionsList";
            this.formPositionsList.Size = new System.Drawing.Size(194, 22);
            this.formPositionsList.Text = "موضع البرنامج";
            // 
            // leftTopStrip
            // 
            this.leftTopStrip.Name = "leftTopStrip";
            this.leftTopStrip.Size = new System.Drawing.Size(134, 22);
            this.leftTopStrip.Text = "أعلى اليسار";
            leftTopStrip.Tag = FormPosition.LeftTop;
            // 
            // rightTopStrip
            // 
            this.rightTopStrip.Name = "rightTopStrip";
            this.rightTopStrip.Size = new System.Drawing.Size(134, 22);
            this.rightTopStrip.Text = "أعلى اليمين";
            rightTopStrip.Tag = FormPosition.RightTop;
            // 
            // leftBottomStrip
            // 
            this.leftBottomStrip.Name = "leftBottomStrip";
            this.leftBottomStrip.Size = new System.Drawing.Size(134, 22);
            this.leftBottomStrip.Text = "أسفل اليسار";
            leftBottomStrip.Tag = FormPosition.LeftBottom;
            // 
            // rightBottomStrip
            // 
            this.rightBottomStrip.Name = "rightBottomStrip";
            this.rightBottomStrip.Size = new System.Drawing.Size(134, 22);
            this.rightBottomStrip.Text = "أسفل اليمين";
            rightBottomStrip.Tag = FormPosition.RightBottom;
            // 
            // formOpacityList
            // 
            this.formOpacityList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opacity50Strip,
            this.opacity60Strip,
            this.opacity70Strip,
            this.opacity80Strip,
            this.opacity90Strip,
            this.opacity100Strip});
            this.formOpacityList.Name = "formOpacityList";
            this.formOpacityList.Size = new System.Drawing.Size(194, 22);
            this.formOpacityList.Text = "شفافية النص";
            // 
            // opacity50Strip
            // 
            this.opacity50Strip.Name = "opacity50Strip";
            this.opacity50Strip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.opacity50Strip.Size = new System.Drawing.Size(102, 22);
            this.opacity50Strip.Text = "50%";
            opacity50Strip.Tag = 0.5;
            // 
            // opacity60Strip
            // 
            this.opacity60Strip.Name = "opacity60Strip";
            this.opacity60Strip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.opacity60Strip.Size = new System.Drawing.Size(102, 22);
            this.opacity60Strip.Text = "60%";
            opacity60Strip.Tag = 0.6;
            // 
            // opacity70Strip
            // 
            this.opacity70Strip.Name = "opacity70Strip";
            this.opacity70Strip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.opacity70Strip.Size = new System.Drawing.Size(102, 22);
            this.opacity70Strip.Text = "70%";
            opacity70Strip.Tag = 0.7;
            // 
            // opacity80Strip
            // 
            this.opacity80Strip.Name = "opacity80Strip";
            this.opacity80Strip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.opacity80Strip.Size = new System.Drawing.Size(102, 22);
            this.opacity80Strip.Text = "80%";
            opacity80Strip.Tag = 0.8;
            // 
            // opacity90Strip
            // 
            this.opacity90Strip.Name = "opacity90Strip";
            this.opacity90Strip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.opacity90Strip.Size = new System.Drawing.Size(102, 22);
            this.opacity90Strip.Text = "90%";
            opacity90Strip.Tag = 0.9;
            // 
            // opacity100Strip
            // 
            this.opacity100Strip.Name = "opacity100Strip";
            this.opacity100Strip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.opacity100Strip.Size = new System.Drawing.Size(102, 22);
            this.opacity100Strip.Text = "100%";
            opacity100Strip.Tag = 1.0;
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
            // progLinkStrip
            // 
            this.progLinkStrip.Name = "progLinkStrip";
            this.progLinkStrip.Size = new System.Drawing.Size(194, 22);
            this.progLinkStrip.Text = "رابط البرنامج";
            // 
            // closeStrip
            // 
            this.closeStrip.Name = "closeStrip";
            this.closeStrip.Size = new System.Drawing.Size(194, 22);
            this.closeStrip.Text = "خروج";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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
        private System.Windows.Forms.ToolStripMenuItem formPositionsList;
        private System.Windows.Forms.ToolStripMenuItem formOpacityList;
        private System.Windows.Forms.ToolStripMenuItem progLinkStrip;
        private System.Windows.Forms.ToolStripMenuItem leftTopStrip;
        private System.Windows.Forms.ToolStripMenuItem rightTopStrip;
        private System.Windows.Forms.ToolStripMenuItem leftBottomStrip;
        private System.Windows.Forms.ToolStripMenuItem rightBottomStrip;
        private System.Windows.Forms.ToolStripMenuItem opacity50Strip;
        private System.Windows.Forms.ToolStripMenuItem opacity60Strip;
        private System.Windows.Forms.ToolStripMenuItem opacity70Strip;
        private System.Windows.Forms.ToolStripMenuItem opacity80Strip;
        private System.Windows.Forms.ToolStripMenuItem opacity90Strip;
        private System.Windows.Forms.ToolStripMenuItem opacity100Strip;
    }
}

