using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static RankModel;
namespace GameApp
{
    public partial class StartForm : Form
    {
        private string[] arrFruit = {
            "E:\\Winform C#\\Lab2\\GameApp\\GameApp\\bin\\Debug\\Images\\fruit\\apple.jpg",
            "E:\\Winform C#\\Lab2\\GameApp\\GameApp\\bin\\Debug\\Images\\fruit\\strawberry.jpg",
            "E:\\Winform C#\\Lab2\\GameApp\\GameApp\\bin\\Debug\\Images\\fruit\\walnut.jpg",
            "E:\\Winform C#\\Lab2\\GameApp\\GameApp\\bin\\Debug\\Images\\fruit\\banana.jpg",
            "E:\\Winform C#\\Lab2\\GameApp\\GameApp\\bin\\Debug\\Images\\fruit\\guava.jpg",
            "E:\\Winform C#\\Lab2\\GameApp\\GameApp\\bin\\Debug\\Images\\fruit\\durian.jpg",
            "E:\\Winform C#\\Lab2\\GameApp\\GameApp\\bin\\Debug\\Images\\fruit\\grapes.jpg",
            "E:\\Winform C#\\Lab2\\GameApp\\GameApp\\bin\\Debug\\Images\\fruit\\orange.jpg",
            "E:\\Winform C#\\Lab2\\GameApp\\GameApp\\bin\\Debug\\Images\\fruit\\pear.jpg",
            "E:\\Winform C#\\Lab2\\GameApp\\GameApp\\bin\\Debug\\Images\\fruit\\watermelon.jpg"
        };
        private string[] arrAnimals = {
            "E:\\Winform C#\\Lab2\\GameApp\\GameApp\\bin\\Debug\\Images\\animals\\bird.jpg",
            "E:\\Winform C#\\Lab2\\GameApp\\GameApp\\bin\\Debug\\Images\\animals\\cat.jpg",
            "E:\\Winform C#\\Lab2\\GameApp\\GameApp\\bin\\Debug\\Images\\animals\\chicken.jpg",
            "E:\\Winform C#\\Lab2\\GameApp\\GameApp\\bin\\Debug\\Images\\animals\\dog.jpg",
            "E:\\Winform C#\\Lab2\\GameApp\\GameApp\\bin\\Debug\\Images\\animals\\duck.jpg",
            "E:\\Winform C#\\Lab2\\GameApp\\GameApp\\bin\\Debug\\Images\\animals\\elephant.jpg",
            "E:\\Winform C#\\Lab2\\GameApp\\GameApp\\bin\\Debug\\Images\\animals\\frog.jpg",
            "E:\\Winform C#\\Lab2\\GameApp\\GameApp\\bin\\Debug\\Images\\animals\\lion.jpg",
            "E:\\Winform C#\\Lab2\\GameApp\\GameApp\\bin\\Debug\\Images\\animals\\monkey.jpg",
            "E:\\Winform C#\\Lab2\\GameApp\\GameApp\\bin\\Debug\\Images\\animals\\tiger.jpg"
        };
        private string[] arrVehicle = {
            "E:\\Winform C#\\Lab2\\GameApp\\GameApp\\bin\\Debug\\Images\\vehicle\\bicycle.png",
            "E:\\Winform C#\\Lab2\\GameApp\\GameApp\\bin\\Debug\\Images\\vehicle\\bus.jpg",
            "E:\\Winform C#\\Lab2\\GameApp\\GameApp\\bin\\Debug\\Images\\vehicle\\car.png",
            "E:\\Winform C#\\Lab2\\GameApp\\GameApp\\bin\\Debug\\Images\\vehicle\\helicopter.png",
            "E:\\Winform C#\\Lab2\\GameApp\\GameApp\\bin\\Debug\\Images\\vehicle\\motorbike.png",
            "E:\\Winform C#\\Lab2\\GameApp\\GameApp\\bin\\Debug\\Images\\vehicle\\plane.jpg",
            "E:\\Winform C#\\Lab2\\GameApp\\GameApp\\bin\\Debug\\Images\\vehicle\\scooter.jpg",
            "E:\\Winform C#\\Lab2\\GameApp\\GameApp\\bin\\Debug\\Images\\vehicle\\ship.jpg",
            "E:\\Winform C#\\Lab2\\GameApp\\GameApp\\bin\\Debug\\Images\\vehicle\\train.jpg",
            "E:\\Winform C#\\Lab2\\GameApp\\GameApp\\bin\\Debug\\Images\\vehicle\\truck.jpg"
        };
        int level = 0;
        int questNo = 0;
        int score = 0;
        bool sound = false;
        string[] questions = new string[5];
        System.Media.SoundPlayer player;
        string path = "E:\\Winform C#\\Lab2\\GameApp\\GameApp\\bin\\Debug\\Profile\\db.txt";
        ArrayList listModel = new ArrayList();

        public StartForm(string qs)
        {
            InitializeComponent();
            Int32.TryParse(qs, out level);
            init();
            initRank();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            checkAnswer();
        }

        private void checkAnswer()
        {
            if (questNo == 0 && (tbAnswer.Text.ToLower() == Path.GetFileNameWithoutExtension(questions[questNo])))
            {
                questNo++;
                score += 2;
                questionPic.ImageLocation = string.Format(questions[questNo]);
                tbAnswer.Text = "";
                lbScore.Text = "Score: " + score;
            }
            else if (questNo == 1 && (tbAnswer.Text.ToLower() == Path.GetFileNameWithoutExtension(questions[questNo])))
            {
                questNo++;
                score += 2;
                questionPic.ImageLocation = string.Format(questions[questNo]);
                tbAnswer.Text = "";
                lbScore.Text = "Score: " + score;
            }
            else if (questNo == 2 && (tbAnswer.Text.ToLower() == Path.GetFileNameWithoutExtension(questions[questNo])))
            {
                questNo++;
                score += 2;
                questionPic.ImageLocation = string.Format(questions[questNo]);
                tbAnswer.Text = "";
                lbScore.Text = "Score: " + score;
            }
            else if (questNo == 3 && (tbAnswer.Text.ToLower() == Path.GetFileNameWithoutExtension(questions[questNo])))
            {
                questNo++;
                score += 2;
                questionPic.ImageLocation = string.Format(questions[questNo]);
                tbAnswer.Text = "";
                lbScore.Text = "Score: " + score;
            }
            else if (questNo == 4 && (tbAnswer.Text.ToLower() == Path.GetFileNameWithoutExtension(questions[questNo])))
            {
                questNo++;
                score += 2;
                tbAnswer.Text = "";
                lbScore.Text = "Score: " + score;
                using (StreamWriter writer = new StreamWriter(path,append:true))
                {
                    writer.Write(DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt") + "; ");
                    writer.Write(level + "; ");
                    writer.Write(score);
                    writer.WriteLine();
                    writer.Close();
                }
                MessageBox.Show("You tried so hard and your score: " + score);
                Form1 form = new Form1();
                form.Show();
                this.Hide();
                player.Stop();
            }
            else
            {

                MessageBox.Show("Wrong answer!!! But you tried so hard and your score: " + score);
                using (StreamWriter writer = new StreamWriter(path, append: true))
                {
                    writer.Write(DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt") + "; ");
                    writer.Write(level + "; ");
                    writer.Write(score);
                    writer.WriteLine();
                    writer.Close();
                }
                Form1 form = new Form1();
                form.Show();
                this.Hide();
                player.Stop();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            setUpSound();
        }

        private void setUpSound()
        {
            if (sound)
            {
                sound = false;
                btnSound.BackgroundImage = Image.FromFile("E:\\Winform C#\\Lab2\\GameApp\\GameApp\\bin\\Debug\\Icon\\mute_icon.png");
                player.Stop();
            }
            else
            {
                sound = true;
                btnSound.BackgroundImage = Image.FromFile("E:\\Winform C#\\Lab2\\GameApp\\GameApp\\bin\\Debug\\Icon\\sound_icon.png");
                player.Play();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void init()
        {
            Random rnd = new Random();

            if (level == 0)
            {
                lbLevel.Text = "Level: Easy";
                int rand = rnd.Next(1, 4);
                if (rand == 1)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        rand = rnd.Next(0, 10);
                        questions[i] = arrFruit[rand];
                    }
                }
                else if (rand == 2)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        rand = rnd.Next(0, 10);
                        questions[i] = arrVehicle[rand];
                    }
                }
                else
                {
                    for (int i = 0; i < 5; i++)
                    {
                        rand = rnd.Next(0, 10);
                        questions[i] = arrAnimals[rand];
                    };
                }
            }
            else if (level == 1)
            {
                int rand = rnd.Next(1, 4);
                int rand2 = rnd.Next(1, 4);
                lbLevel.Text = "Level: Medium";
                if (rand == rand2)
                {
                    while (rand == rand2)
                    {
                        rand2 = rnd.Next(1, 4);
                    }
                }

                if ((rand == 1 && rand2 == 3) || (rand == 3 && rand2 == 1))
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (i % 2 == 0)
                        {
                            rand = rnd.Next(0, 10);
                            questions[i] = arrFruit[rand];
                        }
                        else
                        {
                            rand = rnd.Next(0, 10);
                            questions[i] = arrAnimals[rand];
                        }
                    }
                }
                else if (rand == 1 && rand2 == 2 || rand == 2 && rand2 == 1)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (i % 2 == 0)
                        {
                            rand = rnd.Next(0, 10);
                            questions[i] = arrFruit[rand];
                        }
                        else
                        {
                            rand = rnd.Next(0, 10);
                            questions[i] = arrVehicle[rand];
                        }
                    }
                }
                else if (rand == 2 && rand2 == 3 || (rand == 3 && rand2 == 2))
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (i % 2 == 0)
                        {
                            rand = rnd.Next(0, 10);
                            questions[i] = arrAnimals[rand];
                        }
                        else
                        {
                            rand = rnd.Next(0, 10);
                            questions[i] = arrVehicle[rand];
                        }
                    }
                }
            }
            else
            {
                lbLevel.Text = "Level: Hard";
                for (int i = 0; i < 5; i++)
                {
                    int rand = rnd.Next(1, 4);
                    if (rand == 1)
                    {
                        rand = rnd.Next(0, 10);
                        questions[i] = arrAnimals[rand];
                    }
                    else if (rand == 2)
                    {
                        rand = rnd.Next(0, 10);
                        questions[i] = arrFruit[rand];
                    }
                    else
                    {
                        rand = rnd.Next(0, 10);
                        questions[i] = arrVehicle[rand];
                    }
                }

            }

            questionPic.ImageLocation = string.Format(questions[0]);
            lbScore.Text = "Score: " + score.ToString();
            btnSound.BackgroundImage = Image.FromFile("E:\\Winform C#\\Lab2\\GameApp\\GameApp\\bin\\Debug\\Icon\\sound_icon.png");
            sound = true;
            player = new System.Media.SoundPlayer(@"E:\\Winform C#\\Lab2\\GameApp\\GameApp\bin\\Debug\\Sounds\\nhacgame01.wav");
            player.Play();
        }

        private void initRank()
        {


            using (StreamReader file = new StreamReader(path))
            {
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    string[] info = ln.Split(';');
                    RankModel model = new RankModel();
                    model.setLevel(info[1]);
                    model.setScore(Int32.Parse(info[2]));
                    model.setTime(DateTime.ParseExact(info[0], "MM/dd/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture));

                    listModel.Add(model);
                }
                file.Close();
            }
            listModel.Sort(new ModelComparer());

            lbDate1.Text = ((RankModel)listModel[listModel.Count - 1]).getTime().ToString();
            lbDate2.Text = ((RankModel)listModel[listModel.Count-2]).getTime().ToString();
            lbDate3.Text = ((RankModel)listModel[listModel.Count-3]).getTime().ToString();
            lbDate4.Text = ((RankModel)listModel[listModel.Count-4]).getTime().ToString();
            lbDate5.Text = ((RankModel)listModel[listModel.Count-5]).getTime().ToString();

            lbLevel1.Text = ((RankModel)listModel[listModel.Count-1]).getLevel().ToString();
            lbLevel2.Text = ((RankModel)listModel[listModel.Count-2]).getLevel().ToString();
            lbLevel3.Text = ((RankModel)listModel[listModel.Count-3]).getLevel().ToString();
            lbLevel4.Text = ((RankModel)listModel[listModel.Count-4]).getLevel().ToString();
            lbLevel5.Text = ((RankModel)listModel[listModel.Count-5]).getLevel().ToString();

            lbScore1.Text = ((RankModel)listModel[listModel.Count-1]).getScore().ToString();
            lbScore2.Text = ((RankModel)listModel[listModel.Count - 2]).getScore().ToString();
            lbScore3.Text = ((RankModel)listModel[listModel.Count -3]).getScore().ToString();
            lbScore4.Text = ((RankModel)listModel[listModel.Count -4]).getScore().ToString();
            lbScore5.Text = ((RankModel)listModel[listModel.Count - 5]).getScore().ToString();


        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            player.Stop();
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
