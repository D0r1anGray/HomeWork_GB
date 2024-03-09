package linkedlist.core;


public interface HWlist<T>{
    void add(T elem);
    void add(int index, T elem);
    void remove(int index);
    T get(int index);
    int size();

}
