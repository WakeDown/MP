package DataStructures;

/**
 * Created by trefi
 * Стек реализует схему LIFO (Last In, First Out – последний пришел, первый вышел).
 * Стек можно представить как стопку тарелок.
 * Если положить тарелку на верх стопки, то мы будем иметь доступ только к этой тарелки.
 * Реализовать стек достаточно просто – нужен массив и указатель на верхушку стека.
 * Стек должен поддерживать 2 операции: push(x) – добавить x в стек, и pop() – извлечь верхушку из стека.
 */
public class Stack {
    int size;
    int[] data;

    public Stack(int size) {
        this.data = new int [size];
    }

    void push(int value) {
        data[size++] = value;
        }

    int pop() {
        return data[--size];
    }
}
