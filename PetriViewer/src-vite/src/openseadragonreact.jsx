import { useState, useRef, useEffect } from 'react';
import OpenSeadragon  from 'openseadragon';

function OpenSeaDragonReact() {
    const [count, setCount] = useState(0);
    const divref = useRef(null);

    useEffect(() => {
        if (divref.current) {
            //divref.current.textContent = 'whats up';
            OpenSeadragon({
                id: "example-custom-tilesource",
                prefixUrl: "/openseadragon/images/",
                navigatorSizeRatio: 0.25,
                wrapHorizontal: false,
                tileSources: {
                    height: Infinity,
                    width: Infinity,
                    tileSize: 512,
                    minLevel: 1,
                    //maxLevel: 9,
                    getTileUrl: function (level, x, y) {
                        return "/tiles/" +level + "/" + x*512 + "/" + y*512;
                    }
                }
            });
        }
    }, []);



    return (
        <>
            <div ref={divref} id="example-custom-tilesource">

            </div>
        </>
    )
}

export default OpenSeaDragonReact;
