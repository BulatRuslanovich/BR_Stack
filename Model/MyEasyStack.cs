namespace Stack.Model {
    public class MyEasyStack<T> {
        List<T> items = new List<T>();
        public int Count => items.Count;
        public bool IsEmpty => Count == 0;

        public void Push(T item) {
            items.Add(item);
        }

        public T Pop() {
            if (!IsEmpty) {
                var item = items.LastOrDefault();
                items.Remove(item);
                return item;
            } else {
                throw new NullReferenceException("Stack is empty");
            }
        }

        public T Peek() {
            if (!IsEmpty) {
                var item = items.LastOrDefault();
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
