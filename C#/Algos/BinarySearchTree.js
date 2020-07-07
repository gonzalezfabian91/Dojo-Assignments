/* 
1. Mon
    1. isEmpty
    2. min (with & without recursion)
    3. max (with & without recursion)
*/

class Node {
    constructor(data) {
        this.data = data;
        this.left = null;
        this.right = null;
    }
}

class BinarySearchTree {
    constructor() {
        this.root = null;
    }

    isEmpty() {
        return this.root === null
    }

    min() {
        if(this.isEmpty()){
            return null;
        }
        let runner = this.root;
        while (runner){
            runner = runner.left;
            if (runner.left == null){
                return runner.data;
            }
        }
    }

    minRecursive() {}

    max() {
        if(this.isEmpty()){
            return null;
        }
        let runner = this.root;
        while (runner){
            runner = runner.right;
            if (runner.right == null){
                return runner.data;
            }
        }
    }

    maxRecursive() {}
}

const myNode = new Node(25);
myNode.left = new Node(15);
myNode.right = new Node(50);
const nodeTree = new BinarySearchTree(myNode);
console.log(myNode)
console.log(nodeTree.min()); 



/*
                      root
                  <-- 25 -->
                /            \
              15             50
            /    \         /    \
          10     22      35     70
        /   \   /  \    /  \   /  \
      4    12  18  24  31  44 66  90
  */