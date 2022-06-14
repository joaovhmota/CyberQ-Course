namespace Atividade_15
{
	public partial class FormMain : Form
	{
		string CurrentPlayer;

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


			if (won) DisableGameAndAskAgain();
		}

		private void MakePlay(Button button)
		{
			if (button.Text == "")
			{
				button.Text = CurrentPlayer;
				VerifyGame();
				ChangePlayer();
			}
			else return;

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