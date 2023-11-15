namespace MyStack.Model {
    public class MyLinkedStack<T> {
        private Item<T> Head;
        public int Count { get; private set; }

        public MyLinkedStack() {
            Head = null;
            Count = 0;
        }

        public MyLinkedStack(T data) {
            var item = new Item<T>(data);
            Head = item;
            Count = 1;
        }

        public void Push(T data) {
            var item = new Item<T>(data);
            item.Previous = Head;
            Head = item;
            Count++;
        }

        public T Pop() {
            if (Count > 0) {
                var item = Head;
                Head = Head?.Previous;
                Count--;
                return item.Data;
            } else {
                throw new NullReferenceException("Stack is empty");
            }
        }

        public T Peek() {
            if (Count > 0) {
                return Head.Data;
            } else {
                throw new NullReferenceException("Stack is empty");
            }
        }
    }
}
