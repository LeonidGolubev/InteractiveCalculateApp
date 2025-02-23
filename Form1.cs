using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace InteractiveCalculateApp
{
    public partial class CalcForm : Form
    {
        string _graduateLevel;
        int _startYearNum;
        float size = 14;
        
        public CalcForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _graduateLevel=GraduateLevel.Text;                                    
            //result.Text = _graduateLevel;
            //SaverGraduateLevel(_graduateLevel);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void startYear_TextChanged(object sender, EventArgs e)
        {
            string _startYear = startYear.Text;
            if (startYear.Text != "")
            {
                try
                {
                     _startYearNum = int.Parse(_startYear);
                     erorr_Year.Text="";
                }
                catch { erorr_Year.Text = "Введите число"; }
            }
            

            
        }

        private void startYear_Click(object sender, EventArgs e)
        {
            if (startYear.Text == "введите год")
                 startYear.Clear();
        }

        

        public void Calculate_Click(object sender, EventArgs e)
        {
            if ((startYear.Text != "") & (_startYearNum != 0))
                CalculatePrint(_startYearNum, _graduateLevel);
            else
                erorr_Year.Text = "Введите число";
            //result.Text = $"{_startYearNum}";
        }

        public void CalculatePrint(int _startYear, string graduateLevel)
        {
            int endYear;
            switch (graduateLevel)
            {
                case "Бакалавриат":
                    endYear = _startYear + 4;
                    break;
                case "Магистратура":
                    endYear = _startYear + 2;
                    break;
                case "Специалитет":
                    endYear = _startYear + 5;
                    break;
                default:
                    result.Text = "Выберите уровень образования из списка";
                    endYear = 0;
                    break;
                    
            }

            if ((graduateLevel == "Бакалавриат") | (graduateLevel == "Магистратура") | (graduateLevel == "Специалитет"))
                result.Text = $"В {endYear} году Вы получите уровень образования {graduateLevel}";
        }

        private void result_TextChanged(object sender, EventArgs e)
        {
            result.BackColor = SystemColors.Window;
        }

        private void highText_Click(object sender, EventArgs e)
        {
            
            if (size < 21)
            {
                size += 1;
                if(size > 8)
                    text_min.Visible = false;
                ChengeSizeResult(size);
                label2.Text = $"{size}";
            }

            else
                text_max.Visible = true;
                label2.Text = $"{size}";

        }


        public void ChengeSizeResult(float size)
        {
            if(size==15)
                result.Location = new System.Drawing.Point(45, 307);
            if (size==16)
                result.Location = new System.Drawing.Point(90, 307);
            if (size==17)
                result.Location = new System.Drawing.Point(74, 307);
            if ((size==18) || (size == 19))
                result.Location = new System.Drawing.Point(45, 307);
            if ((size == 20) || (size == 21))
                result.Location = new System.Drawing.Point(130, 307);
           if (size==13)
                result.Location = new System.Drawing.Point(90, 307);
           if (size == 12)
                result.Location = new System.Drawing.Point(115, 307);
           if (size == 11)
                result.Location = new System.Drawing.Point(130, 307);
           if (size == 10)
                result.Location = new System.Drawing.Point(170, 307);
            if (size == 9)
                result.Location = new System.Drawing.Point(190, 307);
            if (size == 8)
                result.Location = new System.Drawing.Point(220, 307);
            result.Font = new System.Drawing.Font("Times New Roman", size, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        }

        private void lowText_Click(object sender, EventArgs e)
        {
            if (size > 8)
            {
                size -= 1;
                if (size < 21)
                    text_max.Visible = false;
                ChengeSizeResult(size);
                label2.Text = $"{size}";
            }

            else
                text_min.Visible = true;
            label2.Text = $"{size}";
        }

        /*public int Getter(ref _startYearNum) 
        {
            return _startYearNum;
        }*/

        /*public string SaverGraduateLevel(string text)
        {
            string Level=text;
            return(Level);
        }*/



    }
}
