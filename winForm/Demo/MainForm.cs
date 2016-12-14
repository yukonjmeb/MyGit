using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multithreading
{
    public partial class Form1 : Form
    {
        public static List<int> itemsA = null;
        public static List<int> itemsB = null;
        private Thread jobThread1, jobThread2;
        // Volatile is used as hint to the compiler that this data
        // member will be accessed by multiple threads.
        private volatile bool _isStop1;
        private volatile bool _isStop2;
        private volatile bool _chkNumber;

        public Form1()
        {
            InitializeComponent();
            itemsA = new List<int>();
            itemsB = new List<int>();
            jobThread1 = new Thread(StartJob1);
            jobThread2 = new Thread(StartJob2);
        }

        public void StartJob1()
        {
            while (!_isStop1)
            {
                Console.WriteLine("Job1處理中...");
                itemsA = GetRandomNumber(itemsA);
                itemsA.Sort();
                this.listBoxA.InvokeIfRequired(() =>
                {
                    listBoxA.Items.Clear();
                });
                foreach (var item in itemsA)
                {
                    this.listBoxA.InvokeIfRequired(() =>
                    {
                        listBoxA.Items.Add(item);
                    });
                }
                Thread.Sleep(1000);

            }
        }

        public void StartJob2()
        {
            while (!_isStop2)
            {
                Console.WriteLine("Job2處理中...");
                if (itemsA.Count == 0)
                {
                    Thread.Sleep(1000);
                    continue;
                }
                itemsA = DelRandomNumber(itemsA);
                itemsA.Sort();
                this.listBoxA.InvokeIfRequired(() =>
                {
                    listBoxA.Items.Clear();
                });
                foreach (var item in itemsA)
                {
                    this.listBoxA.InvokeIfRequired(() =>
                    {
                        listBoxA.Items.Add(item);
                    });
                }
                Thread.Sleep(1000);
            }
        }
        public void StopJob1()
        {
            _isStop1 = true;
        }

        public void StopJob2()
        {
            _isStop2 = true;
        }

        #region 按鈕事件
        private void btnStartA_Click(object sender, EventArgs e)
        {
            Console.WriteLine("開始執行序1");
            jobThread1.Start();
        }

        private void btnStopA_Click(object sender, EventArgs e)
        {
            Console.WriteLine("暫停執行序1");
            jobThread1.Suspend();
        }

        private void btnStartB_Click(object sender, EventArgs e)
        {
            Console.WriteLine("開始執行序2");
            jobThread2.Start();
        }

        private void btnStopB_Click(object sender, EventArgs e)
        {
            Console.WriteLine("暫停執行序2");
            jobThread2.Suspend();
        }
        #endregion

        #region 方法
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //檢查加入的數字是否存在於LIST中，不存在才能夠加入

            int userNumber;
            _chkNumber = false;

            if (int.TryParse(UserNumber.Text, out userNumber))
            {
                foreach (var item in itemsA)
                {
                    if (UserNumber.Text == item.ToString())
                    {
                        _chkNumber = true;
                    }
                }
                
                //parsing successful 
                if (_chkNumber != true)
                {
                    itemsA.Add(userNumber);
                    itemsA.Sort();
                    this.listBoxA.InvokeIfRequired(() =>
                    {
                        listBoxA.Items.Clear();
                    });
                    foreach (var item in itemsA)
                    {
                        this.listBoxA.InvokeIfRequired(() =>
                        {
                            listBoxA.Items.Add(item);
                        });
                    }
                }
            }
            else
            {
                //parsing failed. 
            }
        }

        /// <summary>
        //點選listBoxA項目後，移動至listBoxB中
        /// </summary>
        /// <returns></returns>
        private void listBoxA_SelectedIndexChanged(object sender, EventArgs e)
        {
            var SelectItem = Convert.ToInt32(listBoxA.SelectedItem);

            if (SelectItem>0) {
                itemsA.Remove(SelectItem);
                itemsA.Sort();
                this.listBoxA.InvokeIfRequired(() =>
                {
                    listBoxA.Items.Clear();
                });
                foreach (var item in itemsA)
                {
                    this.listBoxA.InvokeIfRequired(() =>
                    {
                        listBoxA.Items.Add(item);
                    });
                }
                itemsB.Add(SelectItem);
                itemsB.Sort();
            }

            listBoxB.Items.Clear();
            foreach (var item in itemsB) {
                listBoxB.Items.Add(item);
            }
            
        }

        /// <summary>
        /// 產生隨機數字
        /// generates 1-4 integers randomly(1 - 1000000, non-duplicate)
        /// </summary>
        /// <returns></returns>
        private List<int> GetRandomNumber(List<int> pList)
        {
            // 產生隨機1~4數字
            var count = RandomHelper.Next(1, 4);
            // 依照的個數再隨機產生1~1000000之間的數字
            for (int i = 0; i < count; i++)
            {
                var randomNumber = RandomHelper.Next(1, 1000000);
                pList.Add(randomNumber);
            }
            pList.Sort();
            return pList;
        }

        /// <summary>
        /// 刪除0-2個整數
        /// removes 0-2 integers from listboxA
        /// </summary>
        /// <param name="plist"></param>
        private List<int> DelRandomNumber(List<int> pList)
        {
            var processList = pList;
            // 產生隨機0-2數字
            var count = RandomHelper.Next(0, 2);

            //刪除隨機0-2個ListBoxA的項目
            for (int i = 0; i < count; i++)
            {
                var randomNumber = RandomHelper.Next(0, processList.Count - 1);
                var deleteInt = processList[randomNumber];
                Console.WriteLine(string.Format("刪除數字:{0}", deleteInt));
                processList.Remove(deleteInt);
            }
            processList.Sort();
            return processList;
        }
        #endregion
    }
}
