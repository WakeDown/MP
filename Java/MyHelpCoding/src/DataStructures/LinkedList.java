package DataStructures;

/**
 * Created by trefi
 * Каждый элемент списка имеет указатель на следующий элемент (в случае двусвязного списка – еще и на предыдущий).
 * Программисту доступен указатель на начало списка.
 * Зная его, мы можем получить доступ до любого элемента, пройдя последовательно предыдущие элементы.
 * Таким образом, списки удобно применять там, где достаточно только последовательного доступа к данным.
 * Списки можно организовать на массивах, хотя удобнее использовать динамическую память.
 */
public class LinkedList {
    Item list = null; // указатель на список
    /* Добавить в начало */
    void insert(int value) {
    Item insertion = new Item(value);
    if (list == null) {
    list = insertion;
    } else {
    insertion.next = list;
    list.prev = insertion;
    list = insertion;
    }
    }

    /* Добавить в конец */
    void append(int value) {
    Item insertion = new Item(value);
    if (list == null) {
    list = insertion;
    } else {
    Item lastNode = list;
    while (lastNode.next != null)
    lastNode = lastNode.next;
    lastNode.next = insertion;
    insertion.prev = lastNode;
    }
    }
    /* Вставить после заданного узла */
    void insertAfter(Item node, int value) {
    Item insertion = new Item(value);
    Item next = node.next;

    /* Устанавливаем прямые связи */
    node.next = insertion;
    insertion.next = next;
    /* Устанавливаем обратные связи */
    insertion.prev = node;
    if (next != null) // node может быть концом списка!
    next.prev = insertion;
    }

    /* Вставить перед заданным узлом */
    void insertBefore(Item node, int value) {
    Item insertion = new Item(value);
    Item prev = node.prev;

    /* Устанавливаем прямые связи */
    if (prev != null)
    prev.next = insertion;
    else // node может быть началом списка!
    list = insertion;
    insertion.next = node;

    /* Устанавливаем обратные связи */
    insertion.prev = prev;
    node.prev = insertion;
    }

    /* Вставить узел */
    void remove(Item node) {
    Item prev = node.prev;
    Item next = node.next;

    /* Обновляем связи */
    if (prev != null)
    prev.next = next;
    if (next != null)
    next.prev = prev;
    if (node == list)
    list = next;
    }

    /* Класс узла */
    class Item {
    int value;
    Item next;
    Item prev;

    Item(int value) {
    this.value = value;
    }
    }
}
