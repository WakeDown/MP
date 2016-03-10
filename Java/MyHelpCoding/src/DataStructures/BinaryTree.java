package DataStructures;

/**
 * Created by trefi on 10.01.2016.
 */
public class BinaryTree {
   /* Класс ДДП */
    class BinTree {

        Item root = null; // ссылка на корень
    /* Поиск элемента по ключу */
    public Item find(int key) {
    for (Item v = root; v != null; v = key < v.key ? v.left : v.right)
    if (key == v.key)
    return v;
    return null;
    }
    /* Вставка в дерево */
    public boolean add(int key) { // вернет true, если такого ключа не было в дереве
    if (root == null) { // если дерево пусто
    root = new Item(key, null, null); // создаем корень
    return true;
    }
    return add(root, key); // иначе начинаем вставку с корня
    }

    /* Вставка в поддерево */
    private boolean add(Item node, int key) {
    if (key < node.key) { // вставляемый ключ меньше текущего
    if (node.left == null) { // если левого сына нет
    node.left = new Item(key, null, null); // вставляем узел туда
    return true;
    }
    return add(node.left, key); // иначе идем в левое поддерево
    }
    if (key > node.key) { // вставляемый ключ больше текущего
    if (node.right == null) { // если правого сына нет
    node.right = new Item(key, null, null); // вставляем узел туда
    return true;
    }
    return add(node.right, key); // иначе идем в правое поддерево
    }
    return false;
    }
    }

}
