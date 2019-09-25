using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace ObservableCollectionWithRange
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var ocwr = new ObservableCollectionWithRange<string>(new List<string>() { "george", "xiros" });
            ocwr.CollectionChanged += Ocwr_CollectionChanged;

            ocwr.AddRange(new List<string>() { "test 1", "test 2", "test 3", "test 4" });

            //ocwr.Add("test 1");
            //ocwr.Add("test 2");
            //ocwr.Add("test 3");
            //ocwr.Add("test 4");
            Console.ReadKey();
        }

        private static void Ocwr_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {

            if (e.NewItems != null)
            {
                foreach (var i in e.NewItems)
                {
                    Console.WriteLine($"{e.Action} Item {i}");
                }
            }
            else
            {
                Console.WriteLine($"Action {e.Action}");
            }
        }
    }
}
