import { useState, useRef, useEffect } from 'react';

function MyMap() {
    const [tilelist, settilelist] = useState([]);


    var newtilelist = [];
    for (var y = -4; y < 4; y++) {
        for (var x = -4; x < 4; x++) {
            newtilelist.push({
                "x": x * 512,
                "y": y * 512,
                "url": "/tiles/" + 0 + "/" + x * 512 + "/" + y * 512
            });
        }
    }

    //settilelist(newtilelist);

    const listItems = newtilelist.map(person => <img src={person.url} style={{ position: "absolute", top: person.y, left: person.x }} />);




    return (
        <>
            <div id="example-custom-tilesource">
                {listItems}
            </div>
        </>
    )
}

export default MyMap;
