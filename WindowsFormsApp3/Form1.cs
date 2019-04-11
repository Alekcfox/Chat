using System;
using System.Collections.Specialized;
using System.Drawing;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private string name = "NoName"; //Имя пользователя
        private string name2 = "";//Имя собеседника
        private string[][] chatText; // Массив с номером, автором и сообщениями чата
        private string[][] privatChat; //Массив с именами участников приватных чатов
        private int lastMessageNumber = 0; //Номер крайней записи

        public Form1()
        {
            InitializeComponent();


            DoworkAsync(lastMessageNumber, name, name2, "", 10000);//Вызов Демона Чата
        }

        private class AnswerServer //Класс получающий ответ сервера
        {
            public string[][] chat;
            public string[][] privat;
            public string[][] log;
        }

        private async Task DoworkAsync(int lastMessageNumber, string name, string name2, string inputText, int i) //Асинхронная обертка
        {

            await Task.Run(() => SendPing(lastMessageNumber, name, name2, inputText, i));
        }

        private void SendPing(int lastMessageNumber, string name, string name2, string inputText, int i) //Метод-цикл связи
        {
            while (i > 0)
            {
                lastMessageNumber = this.lastMessageNumber;//Синхронизация полей
                name = this.name;
                name2 = this.name2;
                i--;
                Send(lastMessageNumber, name, name2, inputText);

                Thread.Sleep(5000);
            }
        }

        private void Send(int lastMessageNumber2, string name, string name2, string inputText)//метод связи с сервером
        {
         // string url = "http://my1server/index.php";//Адрес хоста
          // string url = "http://swallowchat.000webhostapp/index.php";//https://swallowchat.000webhostapp.com/
         string url = "https://swallowchat.000webhostapp.com/";
            using (var webClient = new WebClient())
            {
                var pars = new NameValueCollection();
                pars.Add("ChatNumber", Convert.ToString(lastMessageNumber2));//Поля отпраки в ПОСТ запрос
                pars.Add("ChatName", name);
                pars.Add("ChatName2", name2);
                pars.Add("ChatInputText", inputText);

                var response = webClient.UploadValues(url, pars); //Метод передачи данных ресурсу
                string str = Encoding.UTF8.GetString(response);//Раскодировка массива байтов

                AnswerServer answerServer = JsonConvert.DeserializeObject<AnswerServer>(str);//Заполнение экземпляра ответом с сервера
                chatText = answerServer.chat;//Ссылка на массив сообщений
                Array.Reverse(chatText);//Пререворачиваем массив
                privatChat = answerServer.privat;//Ссылка на массив приватных чатов

                if (TestBoxL.InvokeRequired) TestBoxL.Invoke(new Action<string>((s) => TestBoxL.Text = s), str);// Техническая инфа о пришедшем массиве
                else TestBoxL.Text = str;

                for (int i = 0; i < chatText.Length; i++)//Заполнение окна чата из асинхронного метода или из обычного
                {
                    if (chatText[i] == null) break;
                    if (ChatWindow.InvokeRequired) ChatWindow.Invoke(new Action<string>((s) => ChatWindow.AppendText(s)), (chatText[i][0] + "--" + chatText[i][1] + " : " + chatText[i][2] + " \n"));
                    else ChatWindow.AppendText((chatText[i][0] + "--" + chatText[i][1] + " : " + chatText[i][2] + " \n"));

                    lastMessageNumber = Convert.ToInt32(chatText[i][0]); //Увеличение счетчика сообщений

                   // if (TestBoxS.InvokeRequired) TestBoxS.Invoke(new Action<string>((s) => TestBoxS.Text = s), Convert.ToString(answerServer.log[0]));
                   // else TestBoxS.Text = Convert.ToString(answerServer.log[0]);// Техническая инфа о счетчике
                }
                ButtonTextRider(privatChat);//Выведение надписей о приватных чатах
            }
        }
        private void ButtonTextRider(string[][] privatChatList) //Метод заполнения надписей на кнопках приватных чатов
        {

            string nameButton;
            Button button = new Button();

            for (int i = 0; i < 6; i++)//Перебор массива приватных чатов
            {
                if (privatChatList.Length > i) { nameButton = privatChatList[i][1] + " ---->   " + privatChatList[i][2]; }
                else nameButton = "";


                if (nameButton != null) //Выбор кнопок по именам
                {
                    button = Privat.Controls["ButtonChat" + i.ToString()] as Button;

                    if (button.InvokeRequired) button.Invoke(new Action<string>((s) => button.Text = s), nameButton);
                    else button.Text = nameButton;
                }
            }
        }

        private void NameBox_KeyPress(object sender, KeyPressEventArgs e)//Ввод имени по нажатию Энтер
        {

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    name = Convert.ToString(NameBox.Text);
                    name2 = "";
                    ButtonChatGray(7);
                }

            }
        }

        private void ChatWindow_TextChanged(object sender, EventArgs e)//Смещение текста чата вверх
        {
            ChatWindow.SelectionStart = ChatWindow.Text.Length;//Задает начальную позицию текста
            ChatWindow.ScrollToCaret();//Сдвигает каретку вниз
        }

        private void ButtonSend_Click(object sender, EventArgs e)//Отправка сообщения
        {
            if (name != "NoName")
            {
                string text = InputBox.Text;
                DoworkAsync(lastMessageNumber, name, name2, text, 1);
                InputBox.Text = "";
            }

        }

        private void InputBox_KeyPress(object sender, KeyPressEventArgs e)//Отправка сообщения по нажатию Энтер
        {
            if (name != "NoName")
            {
                if (Char.IsControl(e.KeyChar))
                {
                    if (e.KeyChar == (char)Keys.Enter)
                    {
                        string text = InputBox.Text;
                        DoworkAsync(lastMessageNumber, name, name2, text, 1);
                        InputBox.Text = "";
                    }
                }
            }
        }

        //Нажатие на кнопки приватных чатов
        private void ButtonChat0_Click(object sender, EventArgs e)
        {
            ButtonPrivatChatClick(0, privatChat);
        }
        private void ButtonChat1_Click(object sender, EventArgs e)
        {
            ButtonPrivatChatClick(1, privatChat);
        }
        private void ButtonChat2_Click(object sender, EventArgs e)
        {

            ButtonPrivatChatClick(2, privatChat);
        }
        private void ButtonChat3_Click(object sender, EventArgs e)
        {
            ButtonPrivatChatClick(3, privatChat);
        }
        private void ButtonChat4_Click(object sender, EventArgs e)
        {
            ButtonPrivatChatClick(4, privatChat);
        }
        private void ButtonChat5_Click(object sender, EventArgs e)
        {
            ButtonPrivatChatClick(5, privatChat);
        }

        private void ButtonPrivatChatClick(int numberButton, string[][] privatChatList) //Метод при нажатии Кнопки приватного  чата
        {
            string nameButton;
            Button button = new Button();
            ChatWindow.Text = "";
            lastMessageNumber = 0;

            for (int i = 0; i < privatChatList.Length; i++)//Перебор массива приватных чатов
            { 
                button = Privat.Controls["ButtonChat" + i.ToString()] as Button;//Присваивание кнопки по имени

                //Присваивание имени собеседнику
                if (i == numberButton && button.BackColor == SystemColors.Control) { name2 = privatChatList[i][1]; }
                if (name2 == name) name2 = privatChatList[i][2];
                if (i == numberButton && button.BackColor == Color.Green) { name2 = ""; }


                //Определение будущего имени кнопки
                if (privatChatList.Length > i) { nameButton = privatChatList[i][1] + " >>>>>>>>   " + privatChatList[i][2]; }
                else nameButton = "";


                if (nameButton != null) //Выбор кнопок по именам
                {
                    if (button.InvokeRequired) button.Invoke(new Action<string>((s) => button.Text = s), nameButton);
                    else button.Text = nameButton;
                }
            }

            //Перекраска кнопок
            ButtonChatGray(numberButton);
        }

        private void ButtonChatGray(int greenButton)//Перекраска кнопок чатов в серый цвет
        {   
                Button button = new Button();

            for (int i = 0; i < 6; i++)
            {
                button = Privat.Controls["ButtonChat" + i.ToString()] as Button;

                if (button.InvokeRequired && i == greenButton && name2!="" ) button.Invoke(new Action<Color>((s) => button.BackColor = s), Color.Green);
                else if (i == greenButton && name2 != "") button.BackColor = Color.Green;
                else if (button.InvokeRequired ) { button.Invoke(new Action<Color>((s) => button.BackColor = s), SystemColors.Control); }
                else  { button.BackColor = SystemColors.Control; }  
            }
        }

        private void CreatePrivatChatButton_Click(object sender, EventArgs e)
        {
            name2 = Name2Box.Text;
            Send(-1, name, name2, "");
            ChatWindow.Text = "";
            lastMessageNumber = 0;
            ButtonChatGray(privatChat.Length-1);
        }//Создание приватного чата

        private void DeletehisChatButton_Click(object sender, EventArgs e)//Удаление чата
        {
            Send(-2, name, name2, "");
            if (name2 != "") { ChatWindow.Text += "\n Удалён приватный чат с" + name2; }
            lastMessageNumber = 0;
            name2 = "";
            ButtonChatGray(7);
        }

        //Удаление серой подсказки
        private void InputBox_Enter(object sender, EventArgs e)
        {
            if (InputBox.ForeColor == Color.Gray)
            {
                InputBox.Text = "";
                InputBox.ForeColor = Color.Black;
            }
        }
        private void NameBox_Enter(object sender, EventArgs e)
        {
            if (NameBox.ForeColor == Color.Gray)
            { 
                NameBox.Text = "";
                NameBox.ForeColor = Color.Black;
            }
            if (NameBox.ForeColor == Color.Red) NameBox.ForeColor = Color.Gray;
        }
    }
}
