import { useState, useRef, useEffect, useCallback } from 'react';
import 'leaflet/dist/leaflet.css';
import L from "leaflet";

function LeafMap() {
	const mapRef = useRef(null);
	console.log("Running leafmap");

	const divref = useCallback((node) => {
		console.log("Called back");
		if (node !== null && !mapRef.current) {
			console.log("Starting map");

            //divref.current.textContent = 'whats up';
			mapRef.current = L.map('map', {
				crs: L.CRS.Simple
			}).setView([0, 0], 0);

			L.tileLayer('/tiles/0/{newx}/{newy}', {
				maxZoom: 19,
				tileSize: 512,
				maxNativeZoom: 0,
				minNativeZoom: 0,
				noWrap: true,
				newx: (data) => { return data.x * 512 },
				newy: (data) => { return data.y * 512 }
			}).addTo(mapRef.current);


			var SectionLayer = L.GridLayer.extend({
				createTile: function (coords) {
					var tile = L.DomUtil.create('div', 'tango-tile');
					console.log(coords);
					tile.width = 2000;
					tile.height = 2000;
					tile.appendChild(document.createTextNode((coords.y * 2000 + coords.x)));

					return tile;
				}
			});

			new SectionLayer({
				maxZoom: 19,
				maxNativeZoom: 0,
				minNativeZoom: 0,
				tileSize: 2000,
				noWrap: true,
			}).addTo(mapRef.current);
        }
    }, []);



    return (
        <>
            <div ref={divref} id="map">

            </div>
        </>
    )
}

export default LeafMap;
