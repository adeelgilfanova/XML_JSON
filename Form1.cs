using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace XML_JSON
{

    public partial class Form1 : Form
    {
        XmlDocument xDoc = new XmlDocument();
        List<People> List = new List<People>();
        public string card;
        public int num;

        public Form1()
        {
            xDoc.Load(@"./../../XMLFile1.xml"); 
            InitializeComponent();
            GetXMLfile();
            LoadToDG(List);
            MainList.Hide();
        }
        private void GetXMLfile()
        {
            XmlElement root = xDoc.DocumentElement;
            ParseDoctors(root);
            ParsePatients(root);
            ParseRelatives(root);
        }

        private void ParseDoctors(XmlElement root)
        {
            foreach (XmlElement node in root)
            {
                if (node.Name == "doctors")
                {
                    foreach (XmlNode child1 in node.ChildNodes)
                    {
                        People d = new People();
                        foreach (XmlNode child in child1.ChildNodes)
                        {
                            switch (child.Name)
                            {
                                case "fio":
                                    d.Name = $"{child.ChildNodes[0].InnerText} {child.ChildNodes[1].InnerText} {child.ChildNodes[2].InnerText}";
                                    break;
                                case "age":
                                    d.Age = int.Parse(child.FirstChild.InnerText);
                                    d.Year = int.Parse(child.LastChild.InnerText);
                                    break;
                                case "status":
                                    d.Status = child.InnerText;
                                    break;
                                case "card":
                                    d.Card = int.Parse(child.InnerText);
                                    break;
                                case "experience":
                                    d.Experience = int.Parse(child.InnerText);
                                    break;

                            }
                        }
                        List.Add(d);
                    }
                }
            }
        }
        private void ParsePatients(XmlElement root)
        {
            foreach (XmlElement node in root)
            {
                if (node.Name == "patients")
                {
                    foreach (XmlNode child1 in node.ChildNodes)
                    {
                        People p = new People();
                        foreach (XmlNode child in child1.ChildNodes)
                        {
                            switch (child.Name)
                            {
                                case "fio":
                                    p.Name = $"{child.ChildNodes[0].InnerText} {child.ChildNodes[1].InnerText} {child.ChildNodes[2].InnerText}";
                                    break;
                                case "age":
                                    p.Age = int.Parse(child.FirstChild.InnerText);
                                    p.Year = int.Parse(child.LastChild.InnerText);
                                    break;
                                case "status":
                                    p.Status = child.InnerText;
                                    break;
                                case "card":
                                    p.Card = int.Parse(child.InnerText);
                                    break;
                                case "disease":
                                    p.Disease = $"{child.ChildNodes[0].InnerText}";
                                    break;
                            }
                        }
                        List.Add(p);
                    }
                }
            }
        }
        private void ParseRelatives(XmlElement root)
        {
            foreach (XmlElement node in root)
            {
                if (node.Name == "relatives")
                {
                    foreach (XmlNode child1 in node.ChildNodes)
                    {
                        People r = new People();
                        foreach (XmlNode child in child1.ChildNodes)
                        {
                            switch (child.Name)
                            {
                                case "fio":
                                    r.Name = $"{child.ChildNodes[0].InnerText} {child.ChildNodes[1].InnerText} {child.ChildNodes[2].InnerText}";
                                    break;
                                case "age":
                                    r.Age = int.Parse(child.FirstChild.InnerText);
                                    r.Year = int.Parse(child.LastChild.InnerText);
                                    break;
                                case "status":
                                    r.Status = child.InnerText;
                                    break;
                                case "card":
                                    r.Card = int.Parse(child.InnerText);
                                    break;
                                case "proximity":
                                    r.Proximity = child.InnerText;
                                    break;
                            }
                        }
                        List.Add(r);
                    }
                }
            }
        }
        private void LoadToDG(List<People> list)
        {
            foreach (People person in list)
            {
                MainList.Rows.Add(person.Name, person.Age, person.Status, person.Card);
            }
        }
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (Card322xml.Checked || Card228xml.Checked || Card123xml.Checked)
            {
                for (int i = 0; i < MainList.Rows.Count; i++)
                {
                    MainList.Rows[i].Visible = MainList[3, i].Value.ToString() == card;
                }
                MainList.Show();
                MessageBox.Show($"Данные по карточке {card} успешно загружены", "Система", MessageBoxButtons.OK);
            }
            else
            {
                MainList.Show();
                MessageBox.Show("Данные по всем карточкам успешно загружены", "Система", MessageBoxButtons.OK);
            }
        }
        private void Card322xml_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Card228xml_CheckedChanged(object sender, EventArgs e)
        {
            card = "322";
        }

        private void Card123xml_CheckedChanged(object sender, EventArgs e)
        {
            card = "228";
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            card = "123";
        }
        private void MainList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AboutPerson per = new AboutPerson();
            num = MainList.CurrentCell.RowIndex;
            per.name = $"ФИО: {List[num].Name}.";
            per.year = $"Год рождения: {List[num].Year}.";
            per.status = $"Статус: {List[num].Status}.";
            per.card = $"Карточка №{List[num].Card}.";
            per.age = $"Возраст: {List[num].Age}.";
            per.temp1 = Tempr(List, num);
            per.Show();
        }
        
        private string Tempr(List<People> List, int num)
        {
            string ans = null;
            if (List[num].Experience != 0)
            {
                ans = $"Опыт работы: {List[num].Experience} лет";
            }
            else if (List[num].Disease != null)
            {
                ans = $"Болезнь: {List[num].Disease}";
            }
            else if (List[num].Proximity != null)
            {
                ans = $"Родственность: {List[num].Proximity}";
            }
            return ans;
        }
        private void SetTree(string str)
        {
            nameLabell.Visible = true;
            ageLabell.Visible = true;
            yearLabell.Visible = true;
            cardLabell.Visible = true;
            temp1Labell.Visible = true;
            personPicture.Visible = true;
            statusLabell.Visible = true;
            People pers = List.Find(per => per.Name.Contains(str));
            nameLabell.Text = $"ФИО: {pers.Name}";
            ageLabell.Text = $"Возраст: {pers.Age}";
            yearLabell.Text = $"Год рождения: {pers.Year}";
            cardLabell.Text = $"Дело №{pers.Card}";
            statusLabell.Text = $"Статус: {pers.Status}";
            if (pers.Experience != 0)
            {
                temp1Labell.Text = $"Опыт работы: {pers.Experience}";
                temp1Labell.Visible = true;
            }
            else if (pers.Disease != null)
            {
                temp1Labell.Text = $"Болезнь: {pers.Disease}";
                temp1Labell.Visible = true;
            }
            else if (pers.Proximity != null)
            {
                temp1Labell.Text = $"Родственность: {pers.Proximity}";
                temp1Labell.Visible = true;
            }
        }

        private void стасянИванИвановичToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SetTree("Стасян");
        }

        private void борцовИльяСергеевичToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SetTree("Борцов");
        }

        private void головинаМарияАлексеевнаToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SetTree("Головина");
        }

        private void минуллинаЛяйсанМаратовнаToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SetTree("Минуллина");
        }

        private void гордеевМитяМаратовичToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SetTree("Гордеев");
        }

        private void мошкинаМарияСергеевнаToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SetTree("Мошкина");
        }

        private void назарбаевРамильРавилевичToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SetTree("Назарбаев");
        }

       
        private void нурмиеваМиланаАлександроваToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SetTree("Нурмиева");
        }

        private void фарраховаЛейсанФазиловнаToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SetTree("Фаррахова");
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
    public class People
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Status { get; set; }
        public int Year { get; set; }
        public int Experience { get; set; }
        public string Disease { get; set; }
        public int Card { get; set; }
        public string Proximity { get; set; }

    }
}
