using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace COMP123_M2020_FinalExam
{
    public partial class AbilityGeneratorForm : Form
    {
        // private Instance Object
        private Random _random;

        private TextBox _firstAbility;
        private TextBox _secondAbility;
        private TextBox _modifiedAbility;



        public AbilityGeneratorForm()
        {
            InitializeComponent();
        }

        private Int32 Roll()
        {
            // create new empty list
            List<Int32> numbers = new List<Int32>();
            int result = 0;

            // roll 4 dice
            for (int count = 0; count < 4; count++)
            {
                int generatedNumber = this._random.Next(0, 6) + 1;
                numbers.Add(generatedNumber);
            }

            // drop the lowest die
            numbers.Remove(numbers.Min());

            // add the numbers to the result

            foreach (int number in numbers)
            {
                result += number;
            }

            // lambda expression equivalent
            //result = numbers.Sum(number => number);

            return result;
        }

        private void GenerateAbilities()
        {
            StrengthTextBox.Text = this.Roll().ToString();
            DexterityTextBox.Text = this.Roll().ToString();
            ConstitutionTextBox.Text = this.Roll().ToString();
            IntelligenceTextBox.Text = this.Roll().ToString();
            WisdomTextBox.Text = this.Roll().ToString();
            CharismaTextBox.Text = this.Roll().ToString();
        }


        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateAbilities();
        }

        private void GeneratorForm_Load(object sender, EventArgs e)
        {
            this._random = new Random(); // initialize random number object

            GenerateAbilities();

            FirstAbilityComboBox.SelectedIndex = 0;
            SecondAbilityComboBox.SelectedIndex = 0;
            ModifyComboBox.SelectedIndex = 0;



        }

        private void SwapButton_Click(object sender, EventArgs e)
        {
            string temporaryAbility;

            temporaryAbility = this._firstAbility.Text;
            this._firstAbility.Text = this._secondAbility.Text;
            this._secondAbility.Text = temporaryAbility;
        }

        private TextBox ChooseAbility(int selectedAbility)
        {
            TextBox textbox = new TextBox();

            switch (selectedAbility)
            {
                case (int)Ability.Strength:
                    textbox = StrengthTextBox;
                    break;
                case (int)Ability.Dexterity:
                    textbox = DexterityTextBox;
                    break;
                case (int)Ability.Constitution:
                    textbox = ConstitutionTextBox;
                    break;
                case (int)Ability.Intelligence:
                    textbox = IntelligenceTextBox;
                    break;
                case (int)Ability.Wisdom:
                    textbox = WisdomTextBox;
                    break;
                case (int)Ability.Charisma:
                    textbox = CharismaTextBox;
                    break;
            }

            return textbox;

        }


        private void FirstAbilityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // make a reference to the first ability selected
            this._firstAbility = ChooseAbility(FirstAbilityComboBox.SelectedIndex);
        }

        private void SecondAbilityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // make a reference to the first ability selected
            this._secondAbility = ChooseAbility(SecondAbilityComboBox.SelectedIndex);
        }

        private void ModifyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // make a reference to the modified ability selected
            this._modifiedAbility = ChooseAbility(ModifyComboBox.SelectedIndex);
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            int ScoreToModify = Convert.ToInt32(this._modifiedAbility.Text);
            ScoreToModify += 1;
            this._modifiedAbility.Text = ScoreToModify.ToString();
            ModifyGroupBox.Enabled = false;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;

            character.Strength = StrengthTextBox.Text;
            character.Dexterity = DexterityTextBox.Text;
            character.Constitution = ConstitutionTextBox.Text;
            character.Intelligence = IntelligenceTextBox.Text;
            character.Wisdom = WisdomTextBox.Text;
            character.Charisma = CharismaTextBox.Text;

            // Step 1 - Hide the parent form
            this.Hide();

            // Step 2 - Instantiate an object for the form type
            // you are going to next
            RaceAndClassForm raceAndClassForm = new RaceAndClassForm();

            // Step 3 - create a property in the next form that 
            // we will use to point to this form
            // e.g. public AbilityGeneratorForm previousForm;

            // Step 4 - point this form to the parent Form 
            // property in the next form
            raceAndClassForm.previousForm = this;

            // Step 5 - Show the next form
            raceAndClassForm.Show();
        }
    }
}
