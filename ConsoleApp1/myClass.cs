using System;

public class Class1
{
	public Class1()
	{
        public void Arraylist()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Insert(0, 3);
            arrayList.Add(4);
            arrayList.Add(50);
            Console.WriteLine(arrayList.Count);
            Console.WriteLine(arrayList.Capacity);
            arrayList.Reverse();
            arrayList.Contains(50);
            Console.WriteLine();
            foreach (int item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
