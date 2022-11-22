using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static oop_8.bossAction;

namespace oop_8
{
    public delegate void bossAction(string message);

    public class Boss
    {
        public event bossAction Notify;

        public int CMS { get; set; }
        public int stateOfDevice { get; set; }
        public Boss(int cMS, int stateOfDevice)
        {
            CMS = cMS;
            this.stateOfDevice = stateOfDevice;
        }

        public void TurnOn(int stateOfDevice)
        {
            if (stateOfDevice == 0)
            {
                Notify?.Invoke("CMS уже выключена и не работает");
            }
            if (stateOfDevice == 1)
            {
                Notify?.Invoke("CMS уже включена и работает");
            }
            else {
                Notify?.Invoke("CMS упала, крепитесь");
                  
            }
        }
        public int bossCondition { get; set; } //почитать про get set 
        public void Upgrade(int bossCondition, int stateOfDevice) 
        {
            if (stateOfDevice == 0) 
            {
                Notify?.Invoke("Босс находится на грани нервного срыва, не любит ждать");
                bossCondition = bossCondition - 1;
            }
            if (stateOfDevice == 1)
            {
                Notify?.Invoke("Босс в хорошем расположении духа");
                bossCondition = bossCondition + 1;
            }
            else
            {
                Notify?.Invoke("Босс сорвался");
                bossCondition = bossCondition - 3;
            }
            if(bossCondition < 1) Notify?.Invoke("Босс всех уволил");

        }
        public int changer( Boss item, int state)
        {
            if (state == 0)
            {
                item.stateOfDevice = 0;

            }
            else if (state == 1)
            {
                item.stateOfDevice = 1;

            }
            else item.stateOfDevice = 3;
            return stateOfDevice;
        }
        public override string ToString()
        {
            return $"CMS содержит {CMS} клиентов и имеет состояние {stateOfDevice}";
        }
    }
}