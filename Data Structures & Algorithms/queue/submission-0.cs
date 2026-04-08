    class Deque
    {
        DoubleEndedQueue _doubleEndedQueue = new();

        public Deque()
        {

        }

        public bool isEmpty()
        {
            return _doubleEndedQueue.IsEmpty();
        }

        public void append(int value)
        {
            _doubleEndedQueue.Enqueque(value);
        }

        public void appendleft(int value)
        {
            _doubleEndedQueue.EnquequeLeft(value);
        }

        public int pop()
        {
            return _doubleEndedQueue.Dequeque();
        }

        public int popleft()
        {
            return _doubleEndedQueue.DequequeLeft();
        }
    }

    class DoubleEndedQueue
    {
        MyDoubleLinkNode _beginning = null;
        MyDoubleLinkNode _end = null;

        public bool IsEmpty()
        {
            return _beginning == null;
        }

        public void Enqueque(int val)
        {
            MyDoubleLinkNode newNode = new MyDoubleLinkNode(val);
            if (_end == null)
            {
                _beginning = _end = newNode;
            }
            else
            {
                _end.next = newNode;
                newNode.prev = _end;
                _end = _end.next;
            }
        }

        public void EnquequeLeft(int val)
        {
            MyDoubleLinkNode newNode = new MyDoubleLinkNode(val);
            if (_end == null)
            {
                _beginning = _end = newNode;
            }
            else
            {
                var oldHead = _beginning;
                _beginning.prev = newNode;
                _beginning = _beginning.prev;
                _beginning.next = oldHead;
            }
        }

        public int Dequeque()
        {
            if (_end == null) return -1;

            int val = _end.val;
            _end = _end.prev;
            if(_end != null) _end.next = null;
            else _beginning = null;

            return val;
        }

        public int DequequeLeft()
        {
            if (_end == null) return -1;

            int val = _beginning.val;
            _beginning = _beginning.next;
            if (_beginning != null) _beginning.prev = null;
            else _end = null;

            return val;
        }
    }

    class MyDoubleLinkNode
    {
        public int val;
        public MyDoubleLinkNode? prev;
        public MyDoubleLinkNode? next;
        public MyDoubleLinkNode(int val = 0, MyDoubleLinkNode? prev = null, MyDoubleLinkNode? next = null)
        {
            this.val = val;
            this.prev = prev;
            this.next = next;
        }
    }
