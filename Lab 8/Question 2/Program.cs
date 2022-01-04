using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
			Pen pen = new Pen();
			pen.StartWriting();
			pen.StopWriting();

			Console.ReadLine();
		}
    }
}

sealed class Pen
{
	public void StartWriting()
	{
		Console.WriteLine("Start writing");
	}
	public void StopWriting()
	{
		Console.WriteLine("Stop writing");
	}
}
