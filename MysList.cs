namespace ClassMetotDemo;

public class MysList<T>
{
     T[] items;

     public MysList()
     {
          items=new T[0];
          
     }

     public void Add(T item)
     {
          T[] tempArray = items;
          items=new T[tempArray.Length+1];
          for (int i = 0; i < tempArray.Length; i++)
          {
               items[i] = tempArray[i];
          }
          items[items.Length-1]=item;
          
     }
     public void Remove(T item)
     {
          T tempItem = item;
          T[] tempArray = items;
          items = new T[items.Length - 1];
          for (int i = 0; i < items.Length; i++)
          {
               if (!item.Equals(tempArray[i]))
               {
                    items[i] = tempArray[i];
               }
          }

     }

     public void Clear()
     {
          items = new T[0];
     }

     public int Count
     {
          get { return items.Length; }
     }

     public T[] Items 
     {
          get { return items; }
     }
     public T FirstOrDefault()
     {
          if (items[0] == null) return default;
          return items[0];
     }

     public T LastOrDefault()
     {
          if (items[0] == null) return default;
          return items[items.Length - 1];
     }
}