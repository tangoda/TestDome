using System;
using System.Collections.Generic;

public class TrainComposition
{
    private LinkedList<int> _tree;

    public TrainComposition()
    {
        _tree = new LinkedList<int>();
    }

    public void AttachWagonFromLeft(int wagonId)
    {
        _tree.AddFirst(wagonId);
    }

    public void AttachWagonFromRight(int wagonId)
    {
        _tree.AddLast(wagonId);
    }

    public int DetachWagonFromLeft()
    {
        var x = _tree.First.Value;
        _tree.RemoveFirst();
        return x;
    }

    public int DetachWagonFromRight()
    {
        var x = _tree.Last.Value;
        _tree.RemoveLast();
        return x;
    }

    public static void Main(string[] args)
    {
        TrainComposition tree = new TrainComposition();
        tree.AttachWagonFromLeft(7);
        tree.AttachWagonFromLeft(13);
        Console.WriteLine(tree.DetachWagonFromRight()); // 7 
        Console.WriteLine(tree.DetachWagonFromLeft()); // 13
    }
}