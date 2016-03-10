package DataStructures;

/**
 * Created by trefi
 * Односторонняя очередь (Queue) реализует схему FIFO (первый пришел, первый ушел)
 * Для реализации очереди нужно помимо массива с данными 2 указателя (на голову и хвост).
 * Хвост указывает на конец очереди, а голова на начало.
 */
public class Queue {
    int size;
    int head; // голова
    int tail; // хвост
    int[] data;

    public Queue(int size) {
        this.data = new int [this.size = size];
    }

    void add(int value) {
        if (++tail == size)
            tail = 0;
        data[tail] = value;
    }

    int extract() {
       if (++head == size)
        head = 0;
       return data[head];
    }

    boolean isEmpty() {
      return head == tail;
    }
}
