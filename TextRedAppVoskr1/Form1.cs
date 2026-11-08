namespace TextRedAppVoskr1
{
    public partial class Form1 : Form
    {
        string name_file = "text.txt"; //Имя файла по умолчанию
        public Form1()
        {
            InitializeComponent();
        }
        //Кнопка открыть 

        private void button1_Click(object sender, EventArgs e)
        {
            //Если произошел диалог запишем в файл
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Прочитаем содержимое файла
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                // Запомним имя файла 
                name_file = openFileDialog1.FileName.ToString();
            }
        }
        //Кнопка сохранить
        private void button2_Click(object sender, EventArgs e)
        {
            // Сохранить данные в файл 
            File.WriteAllText(name_file, textBox1.Text);

        }
        //Кнопка сохранить как
        private void button3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Сохранить данные в файл 
                File.WriteAllText(name_file, textBox1.Text);
                // Сохраняем имя файла
                name_file = saveFileDialog1.FileName.ToString();

            }

        }
        //Кнопка выход
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //Контроль ширины
            if(this.Width < 734)
            {
                //Вернем начальную ширину 
                this.Width = 734;
            }
            if(this.Height < 451)
            {
                this.Height = 451;
            }
        }
    }
}
