using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace hijri_calendar
{
    public partial class Form1 : Form
    {
        bool showMonthName;
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            AddEventHandler();

            SetPropertiesSettings();

            Focus();
            BringToFront();

            SetDate();
        }

        private void SetDate()
        {
            #region Configuration
            object calendarType = Microsoft.Win32.Registry.GetValue(@"HKEY_CURRENT_USER\Control Panel\International", "iCalendarType", null);
            bool isHijri = calendarType != null && calendarType.ToString() == "6";

            Calendar calendar;
            if (isHijri)
                calendar = new GregorianCalendar();
            else
                calendar = new HijriCalendar();

            CultureInfo cultureInfo = new CultureInfo(isHijri ? "en-US" : "ar-SA");
            cultureInfo.DateTimeFormat.Calendar = calendar;
            #endregion

            #region Show Date
            DateTime today = DateTime.Now;

            int year = calendar.GetYear(today);
            int month = calendar.GetMonth(today);
            int day = calendar.GetDayOfMonth(today);

            string monthName;
            if (showMonthName)
                monthName = " " + cultureInfo.DateTimeFormat.GetMonthName(month);
            else
                monthName = "";

            dateLabel.Text = $"{year}/{month:D2}/{day:D2}{monthName}";
            #endregion

            GetFormPosition(pos);
        }

        #region Properties Settings Default
        private void SetPropertiesSettings()
        {
            var def = Properties.Settings.Default;

            winStartup = def.WindowsStartup;
            MenuItem_Click(winStartup ? enableStrip : disableStrip, EventArgs.Empty);


            SetDateLabelType(def.FontType);
            SelectMenuItemBySetting(fontTypeList, def.FontType);

            SetDateLabelStyle(def.FontStyle);
            SelectMenuItemBySetting(fontStyleList, def.FontStyle);

            SetDateLabelSize(def.FontSize);
            SelectMenuItemBySetting(fontSizeList, def.FontSize);

            SetDateLabelColor(def.TextColor);
            SelectMenuItemBySetting(textColorList, def.TextColor);


            showMonthName = def.ShowMonthName;

            SetLangauge(def.Language);
            SelectMenuItemBySetting(languageList, def.Language);

            SetFormPosition((FormPosition)def.FormPosition);
            SelectMenuItemBySetting(formPositionsList, (FormPosition)def.FormPosition);

            SetOpacity(def.Opacity);
            SelectMenuItemBySetting(formOpacityList, def.Opacity);
        }

        private void SelectMenuItemBySetting<T>(ToolStripMenuItem item, T value)
        {
            foreach (ToolStripMenuItem itm in item.DropDownItems)
            {
                if (itm.Tag is T tagValue && EqualityComparer<T>.Default.Equals(tagValue, value))
                {
                    MenuItem_Click(itm, EventArgs.Empty);
                    break;
                }
            }
        }

        private void GetFormPosition(FormPosition pos)
        {
            Rectangle rect = Screen.PrimaryScreen.WorkingArea;
            int screenWidth = rect.Width;
            int screenHeight = rect.Height;

            this.Width = dateLabel.Width;
            this.Height = dateLabel.Height;

            if (pos == FormPosition.LeftTop)
            {
                this.Left = 0;
                this.Top = 0;
            }
            else if (pos == FormPosition.RightTop)
            {
                this.Left = screenWidth - this.Width;
                this.Top = 0;
            }
            else if (pos == FormPosition.LeftBottom)
            {
                this.Left = 0;
                this.Top = screenHeight - this.Height;
            }
            else
            {
                this.Left = screenWidth - this.Width;
                this.Top = screenHeight - this.Height;
            }
        }

        FormPosition pos;
        private void SetFormPosition(FormPosition pos)
        {
            this.pos = pos;

            GetFormPosition(pos);

            Properties.Settings.Default.FormPosition = (int)pos;
            Properties.Settings.Default.Save();
        }

        private void SetOpacity(double opacity)
        {
            Opacity = opacity;
            Properties.Settings.Default.Opacity = opacity;
            Properties.Settings.Default.Save();
        }

        private void SetDateLabelType(string type)
        {
            dateLabel.Font = new Font(type, dateLabel.Font.Size, dateLabel.Font.Style);
            Properties.Settings.Default.FontType = type;
            Properties.Settings.Default.Save();
            SetDate();
        }

        private void SetDateLabelStyle(int style)
        {
            dateLabel.Font = new Font(dateLabel.Font.FontFamily, dateLabel.Font.Size, (FontStyle)style);
            Properties.Settings.Default.FontStyle = style;
            Properties.Settings.Default.Save();
            SetDate();
        }

        private void SetDateLabelSize(float size)
        {
            dateLabel.Font = new Font(dateLabel.Font.FontFamily, size, dateLabel.Font.Style);
            Properties.Settings.Default.FontSize = size;
            Properties.Settings.Default.Save();
            SetDate();
        }

        private void SetDateLabelColor(Color color)
        {
            dateLabel.ForeColor = color;
            Color invert = Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B);
            BackColor = invert;
            TransparencyKey = invert;

            Properties.Settings.Default.TextColor = color;
            Properties.Settings.Default.Save();
        }

        private void SetShowMonthNameBoolean()
        {
            showMonthName = !showMonthName;

            SetShowMonthNameStripText();
            Properties.Settings.Default.ShowMonthName = showMonthName;
            Properties.Settings.Default.Save();
            SetDate();
        }

        int lang = 0;
        private void SetLangauge(int lang)
        {
            this.lang = lang;
            if (lang == 0)
            {
                contextMenuStrip1.RightToLeft = RightToLeft.Yes;
                windowsStartupStrip.Text = "التشغيل عند بدء الويندوز";
                textProperties.Text = "خصائص الخط";
                fontTypeList.Text = "نوع الخط";
                fontStyleList.Text = "نمط الخط";
                regularStyleStrip.Text = "عادي";
                boldStyleStrip.Text = "سميك";
                italicStyleStrip.Text = "مائل";
                boldItalicStyleStrip.Text = "سميك مائل";
                fontSizeList.Text = "حجم الخط";
                textColorList.Text = "لون الخط";
                textColorBlack.Text = "أسود";
                textColorWhite.Text = "أبيض";
                textColorRed.Text = "أحمر";
                textColorGreen.Text = "أخضر";
                textColorLime.Text = "ليموني";
                textColorBlue.Text = "أزرق";
                textColorLightBlue.Text = "أزرق فاتح";
                textColorYellow.Text = "أصفر";
                textColorCyan.Text = "سماوي";
                textColorMagenta.Text = "قرمزي";
                languageList.Text = "اللغة";
                formPositionsList.Text = "موضع البرنامج";
                leftTopStrip.Text = "أعلى اليسار";
                rightTopStrip.Text = "أعلى اليمين";
                leftBottomStrip.Text = "أسفل اليسار";
                rightBottomStrip.Text = "أسفل اليمين";
                formOpacityList.Text = "شفافية النص";
                showMonthNameStrip.Text = "إخفاء إسم الشهر";
                updateStrip.Text = "تحديث التاريخ";
                progLinkStrip.Text = "رابط البرنامج";
                closeStrip.Text = "خروج";
            }
            else if (lang == 1)
            {
                contextMenuStrip1.RightToLeft = RightToLeft.No;
                windowsStartupStrip.Text = "Run at Windows startup";
                textProperties.Text = "Text Properties";
                fontTypeList.Text = "Font Type";
                fontStyleList.Text = "Font Style";
                regularStyleStrip.Text = "Regular";
                boldStyleStrip.Text = "Bold";
                italicStyleStrip.Text = "Italic";
                boldItalicStyleStrip.Text = "Bold Italic";
                fontSizeList.Text = "Font Size";
                textColorList.Text = "Text Color";
                textColorBlack.Text = "Black";
                textColorWhite.Text = "White";
                textColorRed.Text = "Red";
                textColorGreen.Text = "Green";
                textColorLime.Text = "Lime";
                textColorBlue.Text = "Blue";
                textColorLightBlue.Text = "Light Blue";
                textColorYellow.Text = "Yellow";
                textColorCyan.Text = "Cyan";
                textColorMagenta.Text = "Magenta";
                languageList.Text = "Language";
                formPositionsList.Text = "Program Position";
                leftTopStrip.Text = "Left Top";
                rightTopStrip.Text = "Right Top";
                leftBottomStrip.Text = "Left Bottom";
                rightBottomStrip.Text = "Right Bottom";
                formOpacityList.Text = "Text Opacity";
                showMonthNameStrip.Text = "Hide Month Name";
                updateStrip.Text = "Update Date";
                progLinkStrip.Text = "The Program Link";
                closeStrip.Text = "Exit";
            }
            SetWindowsStartupStripText();
            SetShowMonthNameStripText();
            Properties.Settings.Default.Language = lang;
            Properties.Settings.Default.Save();
        }

        bool winStartup;
        private void SetWindowsStartupStripText()
        {
            if (lang == 1)
            {
                if (winStartup)
                {
                    enableStrip.Text = "Enabled";
                    disableStrip.Text = "Disable";
                }
                else
                {
                    enableStrip.Text = "Enable";
                    disableStrip.Text = "Disabled";
                }
            }
            else
            {
                if (winStartup)
                {
                    enableStrip.Text = "مفعل";
                    disableStrip.Text = "تعطيل";
                }
                else
                {
                    enableStrip.Text = "تفعيل";
                    disableStrip.Text = "معطل";
                }
            }
        }

        private void SetShowMonthNameStripText()
        {
            string s;
            if (lang == 1)
            {
                if (showMonthName) s = "Hide month name";
                else s = "Show month name";
            }
            else
            {
                if (showMonthName) s = "إخفاء إسم الشهر";
                else s = "إظهار إسم الشهر";
            }
            showMonthNameStrip.Text = s;
        }

        private void TextColorListUI()
        {
            if ((string)textColorList.Tag == "0")
            {
                textColorList.Tag = "1";
                foreach (ToolStripMenuItem itm in textColorList.DropDownItems)
                {
                    itm.BackColor = Color.Silver;
                    itm.ForeColor = (Color)itm.Tag;
                }
            }
            else if ((string)textColorList.Tag == "1")
            {
                textColorList.Tag = "0";

                foreach (ToolStripMenuItem itm in textColorList.DropDownItems)
                {
                    itm.BackColor = contextMenuStrip1.BackColor;
                    itm.ForeColor = contextMenuStrip1.ForeColor;
                }
            }
        }
        #endregion

        #region Event Handlers
        private void AddEventHandler()
        {
            SetMenuItemClickEvent(windowsStartupStrip);
            enableStrip.Click += (s, ea) => CreateStartupShortcut();
            disableStrip.Click += (s, ea) => DeleteStartupShortcut();


            SetMenuItemClickEvent(fontTypeList);
            SetMenuItemClickEvent<string>(fontTypeList, SetDateLabelType);

            SetMenuItemClickEvent(fontStyleList);
            SetMenuItemClickEvent<int>(fontStyleList, SetDateLabelStyle);

            SetMenuItemClickEvent(fontSizeList);
            SetMenuItemClickEvent<float>(fontSizeList, SetDateLabelSize);

            textColorList.Click += (s, e) => TextColorListUI();
            SetMenuItemClickEvent(textColorList);
            SetMenuItemClickEvent<Color>(textColorList, SetDateLabelColor);


            SetMenuItemClickEvent(languageList);
            SetMenuItemClickEvent<int>(languageList, SetLangauge);

            SetMenuItemClickEvent(formPositionsList);
            SetMenuItemClickEvent<FormPosition>(formPositionsList, SetFormPosition);

            SetMenuItemClickEvent(formOpacityList);
            SetMenuItemClickEvent<double>(formOpacityList, SetOpacity);

            showMonthNameStrip.Click += (s, ea) => SetShowMonthNameBoolean();
            updateStrip.Click += (s, ea) => SetDate();
            dateLabel.MouseHover += (s, ea) => SetDate();
            progLinkStrip.Click += (s, ea) => Process.Start("https://github.com/MohamedAshref371/HijriCalendar/releases/latest");
            closeStrip.Click += (s, ea) => Close();
        }

        private void SetMenuItemClickEvent<T>(ToolStripMenuItem item, Action<T> method)
        {
            foreach (ToolStripMenuItem itm in item.DropDownItems)
                itm.Click += (s, ea) => method((T)itm.Tag);
        }

        private void SetMenuItemClickEvent(ToolStripMenuItem item)
        {
            foreach (ToolStripMenuItem itm in item.DropDownItems)
                itm.Click += MenuItem_Click;
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            if (!(sender is ToolStripMenuItem clickedItem)) return;

            ToolStrip parentMenu = clickedItem.GetCurrentParent();

            foreach (ToolStripItem item in parentMenu.Items)
                if (item is ToolStripMenuItem menuItem)
                    menuItem.Checked = false;

            clickedItem.Checked = true;
        }
        #endregion

        #region Startup Shortcut
        private void CreateStartupShortcut()
        {
            string startupPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            string shortcutPath = Path.Combine(startupPath, $"{Application.ProductName} - Shortcut.lnk");

            if (File.Exists(shortcutPath))
                File.Delete(shortcutPath);

            IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();
            IWshRuntimeLibrary.IWshShortcut shortcut = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(shortcutPath);

            shortcut.TargetPath = Application.ExecutablePath;
            shortcut.WorkingDirectory = Application.StartupPath;
            shortcut.WindowStyle = 1;
            shortcut.Description = $"Shortcut to {Application.ProductName} Application";
            shortcut.IconLocation = Application.ExecutablePath;

            shortcut.Save();

            winStartup = true;
            SetWindowsStartupStripText();
            Properties.Settings.Default.WindowsStartup = true;
            Properties.Settings.Default.Save();
        }

        public void DeleteStartupShortcut()
        {
            string startupPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            string shortcutPath = Path.Combine(startupPath, $"{Application.ProductName} - Shortcut.lnk");

            if (File.Exists(shortcutPath))
                File.Delete(shortcutPath);

            winStartup = false;
            SetWindowsStartupStripText();
            Properties.Settings.Default.WindowsStartup = false;
            Properties.Settings.Default.Save();
        }
        #endregion

    }
}
