using System;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;

namespace Assignment
{
    public class StudentSolution
    {
        class Action
        {
            public string Name;
            public int Value;
        }

        #region Lecture

        public (int Count, int Popped, int Peek, int CountAfterPeek) LCT01_StackSyntax()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3); 

            int count = stack.Count; 
            int popped = stack.Pop(); 
            int peek = stack.Peek(); 
            int countAfterPeek = stack.Count; 

            return (count, popped, peek, countAfterPeek);
        }

        public (int Count, int Dequeued, int Peek, int CountAfterPeek) LCT02_QueueSyntax()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            int count = queue.Count;
            int dequeue = queue.Dequeue();
            int peek = queue.Peek();
            int countAfterPeek = queue.Count;

            return (count, dequeue, peek, countAfterPeek);
        }

        public string[] LCT03_ActionStack()
        {
            Action action1 = new Action { Name = "Action 1" };
            Action action2 = new Action { Name = "Action 2" };
            Action action3 = new Action { Name = "Action 3" };

            Stack<Action> stack = new Stack<Action>();
            stack.Push(action1);
            stack.Push(action2);
            stack.Push(action3);

            int c = stack.Count;
            List<string> actions = new List<string>();
            for (int i = 0; i < c; i++)
            {
                var action = stack.Pop();
                actions.Add(action.Name);
            }

            return actions.ToArray();
        }

        public string[] LCT04_ActionQueue()
        {
            Action action1 = new Action { Name = "Action 1" };
            Action action2 = new Action { Name = "Action 2" };
            Action action3 = new Action { Name = "Action 3" };


            Queue<Action> queue = new Queue<Action>();
            queue.Enqueue(action1);
            queue.Enqueue(action2);
            queue.Enqueue(action3);

            int c = queue.Count;
            List<string> action = new List<string>();
            for (int i = 0; i < c; i++)
            {
                var a = queue.Dequeue();
                action.Add(a.Name);

            }
            return action.ToArray();
        }

        #endregion

        #region Assignment

        public string ASN01_ReverseString(string str)
        {
            if (str == null) return null;

            Stack<char> stack = new Stack<char>();
            string reversedStr = "";

            foreach (char c in str)
            {
                stack.Push(c);
            }

            while (stack.Count > 0)
            {
                reversedStr += stack.Pop();
            }

            return reversedStr;
        }

        public bool ASN02_StackPalindrome(string str)
        {
            if (str == null) return false;

            Stack<char> stack = new Stack<char>();
            string reversedStr = "";

            foreach (char c in str)
            {
                stack.Push(c);
            }

            while (stack.Count > 0)
            {
                reversedStr += stack.Pop();
            }

            return str == reversedStr;
        }

        #endregion

        #region Extra

        public bool EX01_ParenthesesChecker(string str)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
