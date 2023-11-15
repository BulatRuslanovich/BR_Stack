namespace MyStack.Model {
    public class MyArrayStack<T> {
        private T[] items;
        private int current = -1;
        private int size = 10;
        public int Count => items.Length;
        public MyArrayStack(int size = 10) {
            items = new T[size];
        }

        public MyArrayStack(T data, int size = 10) : this(size) {
            items[0] = data;
            current = 0;
        }

        public void Push(T data) {
            if (current < size - 1) {
                current++;
                items[current] = data;
            } else {
                Array.Resize(ref items, size + 10);
                size += 10;
                current++;
                items[current] = data;
            }
        }

        public T Pop() {
            if (current >= 0) {
                var item = items[current];
                items[current] = default(T);
                current--;
                return item;
            } else {
                throw new NullReferenceException("Stack is empty");
            }
        }

        public T Peek() {
            if (current >= 0) {
                var item = items[current];
                return item;
            } else {
                throw new NullReferenceException("Stack is empty");
            }
        }

        public override string ToString() {
            if (Count == 1) {
                return $"Stack has {Count} element";
            }

            return $"Stack has {Count} elements";
        }
    }
}
