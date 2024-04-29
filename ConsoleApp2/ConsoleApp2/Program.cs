// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Parallel Programming - TPL - Task Parallel Library


//Console.WriteLine("Main thread başladı");

//Task task = Task.Factory.StartNew(() =>
//{
//    Console.WriteLine("Görev başladı");

//    for (int count = 0;  count < 10; count++)
//    {
//        Thread.Sleep(500);
//        Console.WriteLine("Task count is "+count);
//    }
//});

//Console.WriteLine("Durum:"+task.Status.ToString());
//task.Wait();

//Console.WriteLine("Durum:"+task.Status.ToString());
//task.Dispose();
//Console.WriteLine("Main thread sona erdi.");

//Task task1 = new Task(MyTask);
//Task taskContinue = task1.ContinueWith(ContTask);
//Thread thread = Thread.CurrentThread;

//Console.WriteLine("Main Thread ID:"+thread.ManagedThreadId);
//Console.WriteLine("ID:" + task1.Id);
//task1.Start();
//taskContinue.Wait();
//task1.Dispose();
//taskContinue.Dispose();

//for (int i = 0; i < 60; i++)
//{
//    Console.WriteLine(".");
//    Thread.Sleep(100);
//}

//task1.Wait();
//Console.WriteLine("Main threat bitti");

//static void MyTask()
//{
//    Console.WriteLine("MyTask() başladı");
//    Console.WriteLine("Current ID:"+Task.CurrentId);

//    for (global::System.Int32 count = 0; count < 10; i++)
//    {
//        Thread.Sleep(500);
//        Console.WriteLine("MyTask() count:"+count);
//    }

//    Console.WriteLine("MyTask() tamamlandı.");
//}

//static void ContTask(Task t)
//{
//    Console.WriteLine("Devam etme işlemi başladı.");
//    for (global::System.Int32 i = 0; i < 5; i++)
//    {
//        Thread.Sleep(500);
//        Console.WriteLine("Continuation count is"+i);
//    }
//    Console.WriteLine("Devam etme işlemi bitti");
//}

//Task<bool> task = Task<bool>.Factory.StartNew(MyTask);

//Console.WriteLine("MyTask() boolean return:"+task.Result);

//Console.WriteLine("---------------");
//Task<int> taskInt = Task<int>.Factory.StartNew(SumIt, 5);
//task.Dispose();
//taskInt.Dispose();
//Console.WriteLine("Main threat bitti");

//static bool MyTask()
//{
//    return true;
//}

//static int SumIt(object v)
//{
//    int x = (int)v;
//    int sum = 0;

//    for (; x > 0; x--)
//    {
//        sum += x;
//    }

//    return sum;
//}


// PLINQ


int[] data = new int[100000000];

for (int i = 0; i < data.Length; i++)
{
    data[i] = i;
}

data[1000] = -1;
data[14000] = -2;
data[15000] = -3;
data[676000] = -4;
data[8024540] = -5;
data[9908000] = -6;
data[6761000] = -7;
data[8024440] = -8;
data[9902300] = -9;

var result = from val in data.AsParallel().AsOrdered()
             where val < 0
             select val;

foreach (var v in result)
{
    Console.Write(v + " ");
}

Console.WriteLine("Main threat bitti");

Console.ReadLine();