public class MyHashSet {

    private List<int>[] list;
    private int size = 1000;
    public MyHashSet() {
        list = new List<int>[1000];
    }
    
    public void Add(int key) {
        var index = key % size;
        var bucket = list[index] ?? new List<int>();
        
        if(bucket != null && bucket.Contains(key)){
            return;
        }
        
        bucket.Add(key);
        list[index] = bucket;
    }
    
    public void Remove(int key) {
        var index = key % size;
        var bucket = list[index];
        if(bucket == null) return;
        bucket.Remove(key);
    }
    
    public bool Contains(int key) {
        var index = key % size;
        var bucket = list[index];
        
        if(bucket == null){
            return false;
        }

        return bucket.Contains(key);
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */