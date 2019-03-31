using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BossScalingStatsFF4FE
{
    class Enemy
    {
        private string _Battle;
        private string _Slot;
        private string _Name;
        private int _Level;
        private int _HP;
        private int _XP;
        private int _GP;
        private int _AtkMult;
        private int _Hit; //hit percentage
        private int _Atk;
        private int _DefMult;
        private int _Evade; //evade percentage
        private int _Defense;
        private int _MagicDefMult;
        private int _MagicEvade; //magic evade percentage
        private int _MagicDefense;
        private int _MinSpeed;
        private int _MaxSpeed;
        private int _Spellpower;
        private string _Misc;

        public string eName
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int eLevel
        {
            get { return _Level; }
            set { _Level = value; }
        }

        public int eHP
        {
            get { return _HP; }
            set { _HP = value; }
        }

        public int eXP
        {
            get { return _XP; }
            set { _XP = value; }
        }
        public int eGP
        {
            get { return _GP; }
            set { _GP = value; }
        }
        public int eAttackMultiplier
        {
            get { return _AtkMult; }
            set { _AtkMult = value; }
        }
        public int eHitPercentage
        {
            get { return _Hit; }
            set { _Hit = value; }
        }
        public int eAttack
        {
            get { return _Atk; }
            set { _Atk = value; }
        }
        public int eDefenseMultiplier
        {
            get { return _DefMult; }
            set { _DefMult = value; }
        }
        public int eEvade
        {
            get { return _Evade; }
            set { _Evade = value; }
        }
        public int eDefense
        {
            get { return _Defense; }
            set { _Defense = value; }
        }
        public int eMagicDefenseMultiplier
        {
            get { return _MagicDefMult; }
            set { _MagicDefMult = value; }
        }
        public int eMagicEvade
        {
            get { return _MagicEvade; }
            set { _MagicEvade = value; }
        }
        public int eMagicDefense
        {
            get { return _MagicDefense; }
            set { _MagicDefense = value; }
        }
        public int eMinSpeed
        {
            get { return _MinSpeed; }
            set { _MinSpeed = value; }
        }
        public int eMaxSpeed
        {
            get { return _MaxSpeed; }
            set { _MaxSpeed = value; }
        }
        public int eSpellpower
        {
            get { return _Spellpower; }
            set { _Spellpower = value; }
        }
        public string eMisc
        {
            get { return _Misc; }
            set { _Misc = value; }
        }

        public string eBattle { get => _Battle; set => _Battle = value; }
        public string eSlot { get => _Slot; set => _Slot = value; }

        public static List<Enemy> loadAllEnemies()
        {
            List<Enemy> enemyList = new List<Enemy>();
            using(var reader = new StreamReader("EnemyData.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    Enemy e = new Enemy();
                    e.eBattle = values[0];
                    e.eSlot = values[1];
                    e.eName = values[2];
                    e.eLevel = Convert.ToInt32(values[3]);
                    e.eHP = Convert.ToInt32(values[4]);
                    e.eXP = Convert.ToInt32(values[5]);
                    e.eGP = Convert.ToInt32(values[6]);
                    e.eAttackMultiplier = Convert.ToInt32(values[7]);
                    e.eHitPercentage = Convert.ToInt32(values[8]);
                    e.eAttack = Convert.ToInt32(values[9]);
                    e.eDefenseMultiplier = Convert.ToInt32(values[10]);
                    e.eEvade = Convert.ToInt32(values[11]);
                    e.eDefense = Convert.ToInt32(values[12]);
                    e.eMagicDefenseMultiplier = Convert.ToInt32(values[13]);
                    e.eMagicEvade = Convert.ToInt32(values[14]);
                    e.eMagicDefense = Convert.ToInt32(values[15]);
                    e.eMinSpeed = Convert.ToInt32(values[16]);
                    e.eMaxSpeed = Convert.ToInt32(values[17]);
                    if (values[18] != "") {
                        e.eSpellpower = Convert.ToInt32(values[18]);
                    } else
                    {
                        e.eSpellpower = 0;
                    }

                    enemyList.Add(e);
                }
            }
            return enemyList;
        }
    }


}
