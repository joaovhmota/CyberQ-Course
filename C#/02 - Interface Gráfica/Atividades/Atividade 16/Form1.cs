namespace Atividade_16
{
	public partial class FormMain : Form
	{
		string CurrentPlayer;
		byte   Plays;

		public FormMain()
		{
			InitializeComponent();
			CurrentPlayer = "X";
		}

		private void ChangePlayer() => CurrentPlayer = (CurrentPlayer == "X") ? "O" : "X";

		private void ChangeButtons(bool b)
		{
			btn1.Enabled = b;
			btn2.Enabled = b;
			btn3.Enabled = b;
			btn4.Enabled = b;
			btn5.Enabled = b;
			btn6.Enabled = b;
			btn7.Enabled = b;
			btn8.Enabled = b;
			btn9.Enabled = b;
		}

		private void ResetButtons()
		{
			btn1.Text = "";
			btn2.Text = "";
			btn3.Text = "";
			btn4.Text = "";
			btn5.Text = "";
			btn6.Text = "";
			btn7.Text = "";
			btn8.Text = "";
			btn9.Text = "";
		}

		private void PlayAgain()
		{
			ChangeButtons(true);
			ResetButtons();
			CurrentPlayer = "O";
			Plays = 0;
		}

		private void ExitGame() => FormMain.ActiveForm.Close();

		private void DisableGameAndAskAgain()
		{
			ChangeButtons(false);

			DialogResult tryAgain = MessageBox.Show("Deseja jogar novamente?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (tryAgain == DialogResult.Yes) PlayAgain();
			else ExitGame();
		}

		private void VerifyGame()
		{
			bool won = false;

			// Linhas
			if (btn1.Text == btn2.Text && btn2.Text == btn3.Text
			    && btn1.Text != "" && btn2.Text != "" && btn3.Text != "") won = true;
			if (btn4.Text == btn5.Text && btn5.Text == btn6.Text
			    && btn4.Text != "" && btn5.Text != "" && btn6.Text != "") won = true;
			if (btn7.Text == btn8.Text && btn8.Text == btn9.Text
			    && btn7.Text != "" && btn8.Text != "" && btn9.Text != "") won = true;

			// Colunas
			if (btn1.Text == btn4.Text && btn4.Text == btn7.Text
			    && btn1.Text != "" && btn4.Text != "" && btn7.Text != "") won = true;
			if (btn2.Text == btn5.Text && btn5.Text == btn8.Text
			    && btn2.Text != "" && btn5.Text != "" && btn8.Text != "") won = true;
			if (btn3.Text == btn6.Text && btn6.Text == btn9.Text
			    && btn3.Text != "" && btn6.Text != "" && btn9.Text != "") won = true;

			// Diagonais
			if (btn1.Text == btn5.Text && btn5.Text == btn9.Text
			    && btn1.Text != "" && btn5.Text != "" && btn9.Text != "") won = true;
			if (btn3.Text == btn5.Text && btn5.Text == btn7.Text
			    && btn3.Text != "" && btn5.Text != "" && btn7.Text != "") won = true;

			if (Plays == 9) DisableGameAndAskAgain();
			if (won) DisableGameAndAskAgain();
		}

		private void MakePlay(Button button)
		{
			if (button.Text == "")
			{
				button.Text = CurrentPlayer;
				VerifyGame();
				ChangePlayer();
				Plays++;
				if (CurrentPlayer == "O") BotPlay();
			}
			else return;
		}

		private void BotPlay()
		{
			int botTry = new Random().Next(10);
			if (botTry == 0) botTry = 1;

			switch(botTry)
			{
				case 1: if (btn1.Text == "") MakePlay(btn1); else BotPlay(); break;
				case 2: if (btn2.Text == "") MakePlay(btn2); else BotPlay(); break;
				case 3: if (btn3.Text == "") MakePlay(btn3); else BotPlay(); break;
				case 4: if (btn4.Text == "") MakePlay(btn4); else BotPlay(); break;
				case 5: if (btn5.Text == "") MakePlay(btn5); else BotPlay(); break;
				case 6: if (btn6.Text == "") MakePlay(btn6); else BotPlay(); break;
				case 7: if (btn7.Text == "") MakePlay(btn7); else BotPlay(); break;
				case 8: if (btn8.Text == "") MakePlay(btn8); else BotPlay(); break;
				case 9: if (btn9.Text == "") MakePlay(btn9); else BotPlay(); break;
			}
		}

		private void btn1_Click(object sender, EventArgs e) => MakePlay(btn1);

		private void btn2_Click(object sender, EventArgs e) => MakePlay(btn2);

		private void btn3_Click(object sender, EventArgs e) => MakePlay(btn3);
		
		private void btn4_Click(object sender, EventArgs e) => MakePlay(btn4);
		
		private void btn5_Click(object sender, EventArgs e) => MakePlay(btn5);

		private void btn6_Click(object sender, EventArgs e) => MakePlay(btn6);

		private void btn7_Click(object sender, EventArgs e) => MakePlay(btn7);

		private void btn8_Click(object sender, EventArgs e) => MakePlay(btn8);

		private void btn9_Click(object sender, EventArgs e) => MakePlay(btn9);

	}
}