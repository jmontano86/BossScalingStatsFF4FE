using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BossScalingStatsFF4FE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Enemy> enemySelections;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void processSelections()
        {
            resetVisibility();
            List<Enemy> enemyList = new List<Enemy>();
            var selectedEnemy = from Enemy in enemySelections
                                where Enemy.eBattle == bossComboBox.SelectedItem.ToString() &&
                                Enemy.eSlot == slotComboBox.SelectedItem.ToString()
                                select Enemy;
            enemyList = selectedEnemy.ToList();
            if(enemyList.Count == 1)
            {
                Enemy en = enemyList[0];
                populateGrid1(en);
                return;
            }
            if(enemyList.Count == 2)
            {
                Enemy en1 = enemyList[0];
                Enemy en2 = enemyList[1];
                Enemy2GroupBox.Visibility = Visibility.Visible;
                populateGrid1(en1);
                populateGrid2(en2);
                return;
            }
            if (enemyList.Count == 3)
            {
                Enemy en1 = enemyList[0];
                Enemy en2 = enemyList[1];
                Enemy en3 = enemyList[2];
                Enemy2GroupBox.Visibility = Visibility.Visible;
                Enemy3GroupBox.Visibility = Visibility.Visible;
                populateGrid1(en1);
                populateGrid2(en2);
                populateGrid3(en3);
                return;
            }
            if (enemyList.Count == 4)
            {
                Enemy en1 = enemyList[0];
                Enemy en2 = enemyList[1];
                Enemy en3 = enemyList[2];
                Enemy en4 = enemyList[3];
                Enemy2GroupBox.Visibility = Visibility.Visible;
                Enemy3GroupBox.Visibility = Visibility.Visible;
                Enemy4GroupBox.Visibility = Visibility.Visible;
                populateGrid1(en1);
                populateGrid2(en2);
                populateGrid3(en3);
                populateGrid4(en4);
                return;
            }
            if (enemyList.Count == 5)
            {
                Enemy en1 = enemyList[0];
                Enemy en2 = enemyList[1];
                Enemy en3 = enemyList[2];
                Enemy en4 = enemyList[3];
                Enemy en5 = enemyList[4];
                Enemy2GroupBox.Visibility = Visibility.Visible;
                Enemy3GroupBox.Visibility = Visibility.Visible;
                Enemy4GroupBox.Visibility = Visibility.Visible;
                Enemy5GroupBox.Visibility = Visibility.Visible;
                populateGrid1(en1);
                populateGrid2(en2);
                populateGrid3(en3);
                populateGrid4(en4);
                populateGrid5(en5);
                return;
            }
            if (enemyList.Count == 6)
            {
                Enemy en1 = enemyList[0];
                Enemy en2 = enemyList[1];
                Enemy en3 = enemyList[2];
                Enemy en4 = enemyList[3];
                Enemy en5 = enemyList[4];
                Enemy en6 = enemyList[5];
                Enemy2GroupBox.Visibility = Visibility.Visible;
                Enemy3GroupBox.Visibility = Visibility.Visible;
                Enemy4GroupBox.Visibility = Visibility.Visible;
                Enemy5GroupBox.Visibility = Visibility.Visible;
                Enemy6GroupBox.Visibility = Visibility.Visible;
                populateGrid1(en1);
                populateGrid2(en2);
                populateGrid3(en3);
                populateGrid4(en4);
                populateGrid5(en5);
                populateGrid6(en6);
                return;
            }


        }

        private void resetVisibility()
        {
            Enemy2GroupBox.Visibility = Visibility.Hidden;
            Enemy3GroupBox.Visibility = Visibility.Hidden;
            Enemy4GroupBox.Visibility = Visibility.Hidden;
            Enemy5GroupBox.Visibility = Visibility.Hidden;
            Enemy6GroupBox.Visibility = Visibility.Hidden;
        }

        private void populateGrid1(Enemy en)
        {
            Enemy1GroupBox.Header = en.eName;
            Level.Text = en.eLevel.ToString();
            HP.Text = en.eHP.ToString();
            XP.Text = en.eXP.ToString();
            GP.Text = en.eGP.ToString();
            AtkMult.Text = en.eAttackMultiplier.ToString();
            Hit.Text = en.eHitPercentage.ToString();
            Attack.Text = en.eAttack.ToString();
            DefMult.Text = en.eDefenseMultiplier.ToString();
            Evade.Text = en.eEvade.ToString();
            Defense.Text = en.eDefense.ToString();
            MagDefMult.Text = en.eMagicDefenseMultiplier.ToString();
            MagEvade.Text = en.eMagicEvade.ToString();
            MagicDefense.Text = en.eMagicDefense.ToString();
            MinSpeed.Text = en.eMinSpeed.ToString();
            MaxSpeed.Text = en.eMaxSpeed.ToString();
            Spellpower.Text = en.eSpellpower.ToString();
        }
        private void populateGrid2(Enemy en)
        {
            Enemy2GroupBox.Header = en.eName;
            Level2.Text = en.eLevel.ToString();
            HP2.Text = en.eHP.ToString();
            XP2.Text = en.eXP.ToString();
            GP2.Text = en.eGP.ToString();
            AtkMult2.Text = en.eAttackMultiplier.ToString();
            Hit2.Text = en.eHitPercentage.ToString();
            Attack2.Text = en.eAttack.ToString();
            DefMult2.Text = en.eDefenseMultiplier.ToString();
            Evade2.Text = en.eEvade.ToString();
            Defense2.Text = en.eDefense.ToString();
            MagDefMult2.Text = en.eMagicDefenseMultiplier.ToString();
            MagEvade2.Text = en.eMagicEvade.ToString();
            MagicDefense2.Text = en.eMagicDefense.ToString();
            MinSpeed2.Text = en.eMinSpeed.ToString();
            MaxSpeed2.Text = en.eMaxSpeed.ToString();
            Spellpower2.Text = en.eSpellpower.ToString();
        }
        private void populateGrid3(Enemy en)
        {
            Enemy3GroupBox.Header = en.eName;
            Level3.Text = en.eLevel.ToString();
            HP3.Text = en.eHP.ToString();
            XP3.Text = en.eXP.ToString();
            GP3.Text = en.eGP.ToString();
            AtkMult3.Text = en.eAttackMultiplier.ToString();
            Hit3.Text = en.eHitPercentage.ToString();
            Attack3.Text = en.eAttack.ToString();
            DefMult3.Text = en.eDefenseMultiplier.ToString();
            Evade3.Text = en.eEvade.ToString();
            Defense3.Text = en.eDefense.ToString();
            MagDefMult3.Text = en.eMagicDefenseMultiplier.ToString();
            MagEvade3.Text = en.eMagicEvade.ToString();
            MagicDefense3.Text = en.eMagicDefense.ToString();
            MinSpeed3.Text = en.eMinSpeed.ToString();
            MaxSpeed3.Text = en.eMaxSpeed.ToString();
            Spellpower3.Text = en.eSpellpower.ToString();
        }
        private void populateGrid4(Enemy en)
        {
            Enemy4GroupBox.Header = en.eName;
            Level4.Text = en.eLevel.ToString();
            HP4.Text = en.eHP.ToString();
            XP4.Text = en.eXP.ToString();
            GP4.Text = en.eGP.ToString();
            AtkMult4.Text = en.eAttackMultiplier.ToString();
            Hit4.Text = en.eHitPercentage.ToString();
            Attack4.Text = en.eAttack.ToString();
            DefMult4.Text = en.eDefenseMultiplier.ToString();
            Evade4.Text = en.eEvade.ToString();
            Defense4.Text = en.eDefense.ToString();
            MagDefMult4.Text = en.eMagicDefenseMultiplier.ToString();
            MagEvade4.Text = en.eMagicEvade.ToString();
            MagicDefense4.Text = en.eMagicDefense.ToString();
            MinSpeed4.Text = en.eMinSpeed.ToString();
            MaxSpeed4.Text = en.eMaxSpeed.ToString();
            Spellpower4.Text = en.eSpellpower.ToString();
        }
        private void populateGrid5(Enemy en)
        {
            Enemy5GroupBox.Header = en.eName;
            Level5.Text = en.eLevel.ToString();
            HP5.Text = en.eHP.ToString();
            XP5.Text = en.eXP.ToString();
            GP5.Text = en.eGP.ToString();
            AtkMult5.Text = en.eAttackMultiplier.ToString();
            Hit5.Text = en.eHitPercentage.ToString();
            Attack5.Text = en.eAttack.ToString();
            DefMult5.Text = en.eDefenseMultiplier.ToString();
            Evade5.Text = en.eEvade.ToString();
            Defense5.Text = en.eDefense.ToString();
            MagDefMult5.Text = en.eMagicDefenseMultiplier.ToString();
            MagEvade5.Text = en.eMagicEvade.ToString();
            MagicDefense5.Text = en.eMagicDefense.ToString();
            MinSpeed5.Text = en.eMinSpeed.ToString();
            MaxSpeed5.Text = en.eMaxSpeed.ToString();
            Spellpower5.Text = en.eSpellpower.ToString();
        }
        private void populateGrid6(Enemy en)
        {
            Enemy6GroupBox.Header = en.eName;
            Level6.Text = en.eLevel.ToString();
            HP6.Text = en.eHP.ToString();
            XP6.Text = en.eXP.ToString();
            GP6.Text = en.eGP.ToString();
            AtkMult6.Text = en.eAttackMultiplier.ToString();
            Hit6.Text = en.eHitPercentage.ToString();
            Attack6.Text = en.eAttack.ToString();
            DefMult6.Text = en.eDefenseMultiplier.ToString();
            Evade6.Text = en.eEvade.ToString();
            Defense6.Text = en.eDefense.ToString();
            MagDefMult6.Text = en.eMagicDefenseMultiplier.ToString();
            MagEvade6.Text = en.eMagicEvade.ToString();
            MagicDefense6.Text = en.eMagicDefense.ToString();
            MinSpeed6.Text = en.eMinSpeed.ToString();
            MaxSpeed6.Text = en.eMaxSpeed.ToString();
            Spellpower6.Text = en.eSpellpower.ToString();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Load data into list
            enemySelections = new List<Enemy>();
            enemySelections = Enemy.loadAllEnemies();
            resetVisibility();

            //Load distinct Data into Battle/Slot positions
            foreach (var item in enemySelections.Select(x => x.eBattle).Distinct())
            {
                bossComboBox.Items.Add(item);
            }

            foreach(var item in enemySelections.Select(x => x.eSlot).Distinct())
            {
                slotComboBox.Items.Add(item);
            }
        }

        private void BossComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (bossComboBox.SelectedIndex != -1 && slotComboBox.SelectedIndex != -1)
            {
                    processSelections();
            }
        }

        private void SlotComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (bossComboBox.SelectedIndex != -1 && slotComboBox.SelectedIndex != -1)
            {
                processSelections();
            }
        }
    }
}
