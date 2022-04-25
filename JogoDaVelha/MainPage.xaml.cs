using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JogoDaVelha
{
    
    public partial class MainPage2 : ContentPage
    {
        /// <summary>
        /// Caso o jogador tenha escolhido jogar com X
        /// </summary>
        public bool playerX { get; set; }

        /// <summary>
        /// Casoo jogador tenha escolhido jogar com O
        /// </summary>
        public bool playerO { get; set; }

        List<Button> list = new List<Button>();

        Random random = new Random();   

        public MainPage2(bool playerX, bool playerO)
        {
            this.playerX = playerX;
            this.playerO = playerO;
            InitializeComponent();
            carregaListaEspacos();
        }

        private void carregaListaEspacos()
        {
            //PRIMEIRA LINHA
            list.Add(this.Content.FindByName<Button>("btn1"));
            list.Add(this.Content.FindByName<Button>("btn2"));
            list.Add(this.Content.FindByName<Button>("btn3"));
            //SEGUNDA LINHA
            list.Add(this.Content.FindByName<Button>("btn4"));
            list.Add(this.Content.FindByName<Button>("btn5"));
            list.Add(this.Content.FindByName<Button>("btn6"));
            //TERCEIRA LINHA
            list.Add(this.Content.FindByName<Button>("btn7"));
            list.Add(this.Content.FindByName<Button>("btn8"));
            list.Add(this.Content.FindByName<Button>("btn9"));

            list.ForEach(item => item.Text = string.Empty);
        }

        private void IAMove()
        {

            int index = random.Next(0, 9);

            var IAChoice = list[index];
            if (string.IsNullOrEmpty(IAChoice.Text))
            {
                if (!playerO)
                    IAChoice.Text = "O";

                if (!playerX)
                    IAChoice.Text = "X";
            }
            else
                IAMove();
            

            VerificaCombinacao();
        }

        /// <summary>
        /// metodo que verifica as possibilidades de vitoria
        /// esse metodo nao é nem um pouco eficiente de escrever
        /// mas eh o que tem pra hoje
        /// </summary>
        private void VerificaCombinacao()
        {
            //PRIMEIRA LINHA
            if (list[0].Text.Equals("X") && list[1].Text.Equals("X") && list[2].Text.Equals("X"))
                WinConditions();            
            else if (list[0].Text.Equals("O") && list[1].Text.Equals("O") && list[2].Text.Equals("O"))
                WinConditions();
            

            //SEGUNDA LINHA
            if (list[3].Text.Equals("X") && list[4].Text.Equals("X") && list[5].Text.Equals("X"))
                WinConditions();            
            else if (list[3].Text.Equals("O") && list[4].Text.Equals("O") && list[5].Text.Equals("O"))
                WinConditions();
            

            //TERCEIRA LINHA
            if (list[6].Text.Equals("X") && list[7].Text.Equals("X") && list[8].Text.Equals("X"))
                WinConditions();            
            else if (list[6].Text.Equals("O") && list[7].Text.Equals("O") && list[8].Text.Equals("O"))
                WinConditions();
            


            //PRIMEIRA COLUNA
            if (list[0].Text.Equals("X") && list[3].Text.Equals("X") && list[6].Text.Equals("X"))
                WinConditions();
            else if (list[0].Text.Equals("O") && list[3].Text.Equals("O") && list[6].Text.Equals("O"))
                WinConditions();
            

            //SEGUNDA COLUNA
            if (list[1].Text.Equals("X") && list[4].Text.Equals("X") && list[7].Text.Equals("X"))
                WinConditions();            
            else if (list[1].Text.Equals("O") && list[4].Text.Equals("O") && list[7].Text.Equals("O"))
                WinConditions();
            

            //TERCEIRA COLUNA
            if (list[2].Text.Equals("X") && list[5].Text.Equals("X") && list[8].Text.Equals("X"))
                WinConditions();            
            else if (list[2].Text.Equals("O") && list[5].Text.Equals("O") && list[8].Text.Equals("O"))
                WinConditions();
            
        }

        private void WinConditions()
        {
            if (playerX)
            {
                DisplayAlert("Atenção", "Você venceu", "ok");
                Navigation.PopAsync();
            }
            else if (playerO)
            {
                DisplayAlert("Atenção", "Você venceu", "ok");
                Navigation.PopAsync();
            }
            else
            {
                DisplayAlert("Atenção", "Você perdeu", "ok");
                Navigation.PopAsync();
            }
        }

        #region[EVENTOS]
        private void btn1_Clicked(object sender, EventArgs e)
        {
            if (playerX)
                btn1.Text = "X";
            
            if (playerO)
                btn1.Text = "O";
            
            IAMove();
        }

        private void btn2_Clicked(object sender, EventArgs e)
        {
            if (playerX)
                btn2.Text = "X";
             

            if (playerO)
                btn2.Text = "O";
            
            IAMove();
        }

        private void btn3_Clicked(object sender, EventArgs e)
        {
            if (playerX)
                btn3.Text = "X";
             

            if (playerO)
                btn3.Text = "O";
            
            IAMove();
        }

        private void btn4_Clicked(object sender, EventArgs e)
        {
            if (playerX)
                btn4.Text = "X";
             

            if (playerO)
                btn4.Text = "O";
            
            IAMove();
        }

        private void btn5_Clicked(object sender, EventArgs e)
        {
            if (playerX)
                btn5.Text = "X";
             

            if (playerO)
                btn5.Text = "O";
            
            IAMove();
        }

        private void btn6_Clicked(object sender, EventArgs e)
        {
            if (playerX)
                btn6.Text = "X";
             

            if (playerO)
                btn6.Text = "O";
            
            IAMove();
        }

        private void btn7_Clicked(object sender, EventArgs e)
        {
            if (playerX)
                btn7.Text = "X";
            

            if (playerO)
                btn7.Text = "O";
            
            IAMove();
        }

        private void btn8_Clicked(object sender, EventArgs e)
        {
            if (playerX)
                btn8.Text = "X";

            if (playerO)
                btn8.Text = "O";
         
            IAMove();
        }

        private void btn9_Clicked(object sender, EventArgs e)
        {
            if (playerX)
                btn9.Text = "X";
            
            if (playerO)
                btn9.Text = "O";
        
            IAMove();
        }
        #endregion
    }
}
