import React, {useState} from 'react';

const TabsInfo = props => {
    const [tabs, setTabs] = useState ([
        {
            name: "Tab 1",
            message: "Tab 1 info",
            selected: false
        },
        {
            name: "Tab 2",
            message: "Tab 2 info",
            selected: false
        },
        {
            name: "Tab 3",
            message: "Tab 3 info",
            selected: false
        }
    ])

    const onClickHandler = (e, value, index) => {
        let newTab = value;
        let newTabs = [].concat(...tabs);

        for(let i = 0; i < newTabs.length; i++){
            if (newTabs[i] === newTabs[index]){
                newTabs[i] =({
                    name: newTab.name,
                    message: newTab.message,
                    selected: true
                });
            }
            else{
                let temp = newTabs[i];
                newTabs[i] = ({
                    name:temp.name,
                    message: temp.message,
                    selected: false
                });
            }
            setTabs(newTabs);
        }
    }
    return tabs.map((item, index) => {

        
        return (
            <>
                <div>
                    <button onClick={(e) => onClickHandler(e, item, index)}>{item.name}</button>
                </div>
                <div>
                    {item.selected &&
                        <p>{item.message}</p>
                    }
                </div>
                <hr/>
            </>
        );
    })
}

export default TabsInfo;