package DataStructures;

import java.util.Arrays;

/**
 * Created by trefi
 * Хэш-таблица – очень важная структура данных.
 * С помощью хэш-таблицы можно эффективно реализовать ассоциативный массив (карту).

 Работа хэш-таблиц основана на хэш-функциях.
 Пусть у нас есть некоторое множество объектов A = {…, a, b, ...}.
 Введем такую функцию f, которая каждому объекту ставит в соответствие некоторое число.
 Тогда очевидно, что если f(a) != f(b), то a точно не совпадает с b.
 Преимущество использования хэш-функций хорошо проявляется при сравнении строк, числовых последовательностей и т.д.
 Однако, на хэш-функцию накладываются ограничения.
 Во-первых, она должна быстро вычисляться.
 Во-вторых, ее значения должны быть равномерно распределены по области определения (она ограничивается типом возвращаемого значения).
 Равномерность хэш-функции снижает число коллизий – совпадений значения хэш-функции для разных объектов.
 Заметим, что если f(a) = f(b), то нам придется явно проверить, равны ли a и b, что для тех же строк требует много времени.

 Вернемся к хэш-таблицам.
 Нам нужно научиться реализовывать структуры данных типа «множество» (set) с операциями add(x) (добавить элемент x в множество)
 и contains(x) (проверить, содержится ли x в множестве),
 и «словарь» (ассоциативный массив) с операциями put(x, y) (сопоставить ключу x значение y) и
 get(x) (вернуть значение y, сопоставленное ключу x). Есть несколько вариантов реализации данных структур данных,
 причем как с использованием хэш-функций, так и с использованием других методов и алгоритмов (например двоичных деревьев).

 Основной проблемой при реализации хэш-таблицы является обработка коллизий.
 Есть 2 основных метода: метод цепочек и открытая адресация. Они очень просты как для понимания, так и в реализации.

 Рассмотрим метод цепочек.
 Фактически, мы просто модифицируем мультиспискок.
 Пусть у нас есть хэш-функция hash(x) для объектов из некоторго множества A.
 Теперь придумаем такую функцию index(y), которая по значению обычной хэш-функции будет возвращать номер головы в мультисписке.
 Пусть у нас H голов, тогда можно взять index(y) = abs(y) % H. Дальше все аналогично обычному мультисписку.

 Открытая адресация еще проще в реализации.
 Ее идея заключается в следующем: пусть есть достаточно большой массив для хранения элементов множества.
 Введем функцию index(y), которая по значению обычной хэш-функции будет возвращать отступ в этом массиве.
 Но как же обойти коллизии? Все достаточно просто: для каждой ячейки массива будем поддерживать информацию о том занята ли она.
 Теперь при добавлении элемента мы получим отступ в массиве.
 Если соответствующая ячейка занята, перейдем к следующей (если дошли до конца, то вернуться на начало).
 И так, пока не дойдем до первой незанятой ячейки. В нее и положим добавляемый элемент.
 Аналогично делается поиск элемента в множестве.
 Самое главное, аккуратно подобрать размер массива – он должен быть строго больше максимального числа элементов.
 К тому же, для данной реализации очень важно подобрать хорошую хэш-функцию.
 */
public class TheHashTable {
    int[] head; // массив голов
    int[] next; // массив ссылок на следующий элемент
    int[] keys; // массив с ключами (вместо int'а следует поставить нужный тип)
    int headNum; // количество голов
    int cnt = 1; // ссылка на место для вставки нового эдемента

    /* Конструктор */
    TheHashTable(int headNum, int maxSize) {
    this.headNum = headNum;
    head = new int [headNum];
    next = new int [maxSize + 1];
    keys = new int [maxSize + 1];
    }

    /* Добавляет элемент в множество */
    boolean add(int x) {
    if (this.contains(x))
    return false;
    int h = index(hash(x));
    next[cnt] = head[h];
    keys[cnt] = x;
    head[h] = cnt++;
    return true;
    }

    /* Проверяет, содержится ли x в множестве */
    boolean contains(int x) {
    int h = index(hash(x));
    for (int i = head[h]; i != 0; i = next[i])
    if (keys[i] == x)
    return true;
    return false;
    }

    /* хэш-функция (для других типов следует изменить) */
    int hash(int x) {
    return (x >> 15) ^ x;
    }

    /* возвращает номер головы по значению хэш-функции */
    int index(int hash) {
    return Math.abs(hash) % headNum;
    }
    }

    /* Простая реализация HashSet'а методом открытой адресации для интов */
    class OpenHashSet {
    int FREE = Integer.MIN_VALUE;
    int size;
    int[] keys;

    /* Конструктор */
    OpenHashSet(int size) {
    this.size = Math.max(3 * size / 2, size) + 1;
    keys = new int [this.size];
    Arrays.fill(keys, FREE);
    }

     /* Добавляет элемент в множество */
    boolean add(int x) {
    for (int i = index(hash(x)); ; i++) {
    if (i == size) i = 0;
    if (keys[i] == x) return false;
    if (keys[i] == FREE) {
    keys[i] = x;
    return true;
    }
    }
    }

    /* Проверяет, содержится ли x в множестве */
    boolean contains(int x) {
    for (int i = index(hash(x)); ; i++) {
    if (i == size) i = 0;
    if (keys[i] == x) return true;
    if (keys[i] == FREE) return false;
    }
    }

    /* хэш-функция (для других типов следует изменить) */
    int hash(int x) {
    return (x >> 15) ^ x;
    }

    /* возвращает отступ для данного значения хэш-функции */
    int index(int hash) {
    return Math.abs(hash) % size;
    }
    }

    /* Простая реализация HashMap'а методом открытой адресации для интов */
    class OpenHashMap {
    int FREE = Integer.MIN_VALUE;
    int size;
    int[] keys;
    int[] values;

    /* Конструктор */
    OpenHashMap(int size) {
    this.size = Math.max(3 * size / 2, size) + 1;
    keys = new int [this.size];
    values = new int [this.size];
    Arrays.fill(keys, FREE);
    }

    /* Добавляет пару в множество */
    void put(int x, int y) {
    for (int i = index(hash(x)); ; i++) {
    if (i == size) i = 0;
    if (keys[i] == FREE)
    keys[i] = x;
    if (keys[i] == x) {
    values[i] = y;
    return;
    }
    }
    }

    /* Извлекает значение */
    int get(int x) {
    for (int i = index(hash(x)); ; i++) {
    if (i == size) i = 0;
    if (keys[i] == FREE) throw new RuntimeException("No such key!");
    if (keys[i] == x) return values[i];
    }
    }

    /* Проверяет наличие пары с ключем x */
    boolean containsKey(int x) {
    for (int i = index(hash(x)); ; i++) {
    if (i == size) i = 0;
    if (keys[i] == FREE) return false;
    if (keys[i] == x) return true;
    }
    }

    /* хэш-функция (для других типов следует изменить) */
    int hash(int x) {
    return (x >> 15) ^ x;
    }

    /* возвращает номер головы по значению хэш-функции */
    int index(int hash) {
    return Math.abs(hash) % size;
    }
    }

    /* Оптимизированный вариант HashSet'а для интов */
    class FastHashMap {
    int HEAD_NUM;
    int MASK;

    int[] head;
    int[] next;
    int[] keys;
    int[] values;
    int cnt = 1;

    FastHashMap(int degree, int maxSize) {
    HEAD_NUM = 1 << degree;
    MASK = HEAD_NUM - 1;
    head = new int [HEAD_NUM];
    next = new int [maxSize + 1];
    keys = new int [maxSize + 1];
    values = new int [maxSize + 1];
    }

    void put(int x, int y) {
    int h = index(x);
    for (int i = head[h]; i != 0; i = next[i])
    if (keys[i] == x) {
    values[i] = y;
    return;
    }
    next[cnt] = head[h];
    keys[cnt] = x;
    values[cnt] = y;
    head[h] = cnt++;
    }

    int get(int x) {
    int h = index(x);
    for (int i = head[h]; i != 0; i = next[i])
    if (keys[i] == x)
    return values[i];
    throw new RuntimeException("No such key!");
    }

    boolean containsKey(int x) {
    int h = index(x);
    for (int i = head[h]; i != 0; i = next[i])
    if (keys[i] == x)
    return true;
    return false;
    }

    int index(int x) {
    return Math.abs((x >> 15) ^ x) & MASK;
    }
}
