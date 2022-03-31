using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EncodDecod
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод шифрования текста
        /// </summary>
        /// <param name="encryption"></param>
        public void shifdesh(bool encryption = true) 
        {
            string text = textBoxEncryption.Text;
            textBoxEncryption.Clear();

            for (int i = 0; i < text.Length; i++)
                textBoxEncryption.Text += encryption ? (char)(text[i] + 22) : 
                    (char)(text[i] - 22);
        }

        /// <summary>
        /// Метод вызова окна ошибки
        /// </summary>
        internal void Error()
        {
            MessageBox.Show("Поле ввода текста должно быть заполнено!",
                "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Кнопка для зашифровки текста
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            if (textBoxEncryption.Text != "")
                shifdesh();
            else
                Error();
        }

        /// <summary>
        /// Кнопка для расшифровки текста
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            if (textBoxEncryption.Text != "")
                shifdesh(false);
            else
                Error();
        }

        /// <summary>
        /// Кнопка для копирования текста
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (textBoxEncryption.Text != "")
                Clipboard.SetText(textBoxEncryption.Text);
            else
                Error();
        }

        /// <summary>
        /// Кнопка для вставки текста из буфера обмена
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPaste_Click(object sender, EventArgs e)
        {
            textBoxEncryption.Text = textBoxEncryption.Text +
                Clipboard.GetText();
        }

        /// <summary>
        /// Кнопка для очищения текстового поля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxEncryption.Clear();
        }

        /// <summary>
        /// Кнопка для сохранения текста в файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxEncryption.Text != "")
            {
                SaveFileDialog sfd = new SaveFileDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                    File.WriteAllText(sfd.FileName, textBoxEncryption.Text);
            }
            else
            {
                Error();
            }
        }

        /// <summary>
        /// Кнопка вставки текста из файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFile_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty; // Содержимое файла
            var filePath = string.Empty; // Путь к файлу

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                        textBoxEncryption.Text = fileContent;
                    }
                }
            }
        }

        /// <summary>
        /// Кнопка для вызова справки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
                if (frm is FormHelp)
                {
                    frm.Activate();
                    return;
                }
            FormHelp form = new FormHelp();
            form.Show();
            return;
        }

        /// <summary>
        /// Кнопка для выхода из программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }    

        private void textBoxEncryption_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
