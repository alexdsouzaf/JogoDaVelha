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
        const string opcX = "X";
        const string opcO = "O";

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
            btnPlayAgain.IsVisible =
            btnSair.IsVisible = false;
        }


        private void carregaListaEspacos()
        {
            list.Clear();
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

            list.ForEach(item => {
                item.Text = string.Empty;
                item.IsEnabled = true;            
            });
        }

        private void IAMove()
        {
            try
            {
                int index = random.Next(0, 9);

                var IAChoice = list[index];
                if (string.IsNullOrEmpty(IAChoice.Text))
                {
                    if (!playerO)
                        IAChoice.Text = opcO;

                    if (!playerX)
                        IAChoice.Text = opcX;

                    IAChoice.IsEnabled = false;
                }
                else
                    IAMove();


                VerificaCombinacao();
            }
            catch
            {
                DisplayAlert("ATENÇÃO", "Não existem mais jogadas possíveis", "OK");
            }
        }

        /// <summary>
        /// metodo que verifica as possibilidades de vitoria
        /// esse metodo nao é nem um pouco eficiente de escrever
        /// mas eh o que tem pra hoje
        /// </summary>
        private void VerificaCombinacao()
        {
            //PRIMEIRA LINHA
            if (list[0].Text.Equals(opcX) && list[1].Text.Equals(opcX) && list[2].Text.Equals(opcX))
                WinConditions();            
            else if (list[0].Text.Equals(opcO) && list[1].Text.Equals(opcO) && list[2].Text.Equals(opcO))
                WinConditions();
            

            //SEGUNDA LINHA
            if (list[3].Text.Equals(opcX) && list[4].Text.Equals(opcX) && list[5].Text.Equals(opcX))
                WinConditions();            
            else if (list[3].Text.Equals(opcO) && list[4].Text.Equals(opcO) && list[5].Text.Equals(opcO))
                WinConditions();
            

            //TERCEIRA LINHA
            if (list[6].Text.Equals(opcX) && list[7].Text.Equals(opcX) && list[8].Text.Equals(opcX))
                WinConditions();            
            else if (list[6].Text.Equals(opcO) && list[7].Text.Equals(opcO) && list[8].Text.Equals(opcO))
                WinConditions();
            

            //PRIMEIRA COLUNA
            if (list[0].Text.Equals(opcX) && list[3].Text.Equals(opcX) && list[6].Text.Equals(opcX))
                WinConditions();
            else if (list[0].Text.Equals(opcO) && list[3].Text.Equals(opcO) && list[6].Text.Equals(opcO))
                WinConditions();
            

            //SEGUNDA COLUNA
            if (list[1].Text.Equals(opcX) && list[4].Text.Equals(opcX) && list[7].Text.Equals(opcX))
                WinConditions();            
            else if (list[1].Text.Equals(opcO) && list[4].Text.Equals(opcO) && list[7].Text.Equals(opcO))
                WinConditions();
            

            //TERCEIRA COLUNA
            if (list[2].Text.Equals(opcX) && list[5].Text.Equals(opcX) && list[8].Text.Equals(opcX))
                WinConditions();            
            else if (list[2].Text.Equals(opcO) && list[5].Text.Equals(opcO) && list[8].Text.Equals(opcO))
                WinConditions();
            
        }

        private void WinConditions()
        {
            
            if (playerX || playerO)
                DisplayAlert("Atenção", "Você venceu!","OK");
            else
                DisplayAlert("Atenção", "Você perdeu!", "OK");

            btnPlayAgain.IsVisible = 
            btnSair.IsVisible = true;

            list.ForEach(item => item.IsEnabled = false);
        }

        #region[EVENTOS]
        private void btn1_Clicked(object sender, EventArgs e)
        {
            if (playerX)
                btn1.Text = opcX;
            
            if (playerO)
                btn1.Text = opcO;
            
            IAMove();
        }

        private void btn2_Clicked(object sender, EventArgs e)
        {
            if (playerX)
                btn2.Text = opcX;
             

            if (playerO)
                btn2.Text = opcO;

            IAMove();
        }

        private void btn3_Clicked(object sender, EventArgs e)
        {
            if (playerX)
                btn3.Text = opcX;
             

            if (playerO)
                btn3.Text = opcO;

             IAMove();
        }

        private void btn4_Clicked(object sender, EventArgs e)
        {
            if (playerX)
                btn4.Text = opcX;
             

            if (playerO)
                btn4.Text = opcO;

            IAMove();
        }

        private void btn5_Clicked(object sender, EventArgs e)
        {
            if (playerX)
                btn5.Text = opcX;
             

            if (playerO)
                btn5.Text = opcO;

            IAMove();
        }

        private void btn6_Clicked(object sender, EventArgs e)
        {
            if (playerX)
                btn6.Text = opcX;
             

            if (playerO)
                btn6.Text = opcO;

            IAMove();
        }

        private void btn7_Clicked(object sender, EventArgs e)
        {
            if (playerX)
                btn7.Text = opcX;
            

            if (playerO)
                btn7.Text = opcO;

            IAMove();
        }

        private void btn8_Clicked(object sender, EventArgs e)
        {
            if (playerX)
                btn8.Text = opcX;

            if (playerO)
                btn8.Text = opcO;

             IAMove();
        }

        private void btn9_Clicked(object sender, EventArgs e)
        {
            if (playerX)
                btn9.Text = opcX;
            
            if (playerO)
                btn9.Text = opcO;

            IAMove();
        }

        private void btnPlayAgain_Clicked(object sender, EventArgs e) => carregaListaEspacos();
        
        private void btnSair_Clicked(object sender, EventArgs e) => Application.Current.MainPage = new NavigationPage(new SelectionPage());
        
        #endregion

    }
}
