using System;

    namespace Day3IfElse
    {
        public class MasterMindGame
        {
            private void button6_Click(object sender, EventArgs e)
            {
                pictureBox1.BackColor = Color.FromArgb(r.Next(0, 256),
                        r.Next(0, 256), r.Next(0, 256));

                Console.WriteLine(pictureBox1.BackColor.ToString());
            }
        }
    }