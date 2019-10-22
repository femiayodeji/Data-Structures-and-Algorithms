using System;
public class ArrayList<T>{
    private T[] _storage;
    private int _lastItemIndex;

    public ArrayList(){
        _storage = new T[4];
        _lastItemIndex = -1;
    }

    public void Add(T item){
        if(_lastItemIndex == _storage.Length -1){
            ExpandStorage();
        }
        _lastItemIndex++;
        _storage[_lastItemIndex] = item;
    }

    public void Insert(int index, T item){
        ValidateIndex(index);

        if(_lastItemIndex ==_storage.Length-1){
            ExpandStorage();
        }
        
        //the segment for insertion
        int segmentLength = _lastItemIndex - index +1;

        //copy the segment to free up space for the new item
        Array.Copy(_storage,index,_storage,index+1,segmentLength);
        _lastItemIndex++;
        _storage[index] = item;
    }

    public T this[int index]{
        get{
            ValidateIndex(index);
            return _storage[index];
        }
        set{
            ValidateIndex(index);
            _storage[index] = value;
        }
    }

    public int Length => _lastItemIndex+1;

    public int StorageLength => _storage.Length;
    public void PrintElements(){
        string str = "";
        for(int i = 0; i <= _lastItemIndex; i++){
            str += _storage[i]+",";
        }
        Console.WriteLine("["+str.Trim(',')+"]");
    }

    public void ExpandStorage(){
        var newStorage = new T[_storage.Length*2];
        Array.Copy(_storage,newStorage,_storage.Length);
        _storage = newStorage;
    }

    public void ValidateIndex(int index){
        if (index < 0 || index > _lastItemIndex)
            throw new ArgumentOutOfRangeException(nameof(index));
    }
}