function getScreenSize() {
    const width = window.innerWidth;
    if (width >= 1536) {
        return 0.1; // 2XL screens (1536px and above)
    } else if (width >= 1280) {
        return 0.2; // XL screens (1280px to 1535px)
    } else if (width >= 1024) {
        return 0.01; // Large screens (1024px to 1279px)
    } else {
        return 0.01; // Small to medium screens (below 1024px)
    }
}


function gaugeGlazemin(Idcontainer, valueInput) {

    const container = document.getElementById(Idcontainer);
    const width = container.clientWidth;
    const height = container.clientHeight;
    const percentage = getScreenSize() //10%
   
    var data = [
    {
        type: "indicator",
        mode: "number+gauge",
        value: valueInput,
        gauge: {
            shape: "bullet",
            axis: { range: [0, 5000],  ticks: "inside",
                tickmode: "auto", ticklen: height * 0.4, nticks: 20
            },
             bar: {
                color: "rgba(0, 0, 0, 0)", // Set the background color to transparent
                line: { color: "blue", width: 3},
                thickness: 1
            },
            steps: [
                { range: [0, 1000], color: "white" },
                { range: [1000, 4000], color: "green" },
                { range: [4000, 4800], color: "yellow" },
                { range: [4800, 5000], color: "red" }
            ]
        },
        domain: { x: [0, 1], y: [0, 1] },
        //title: { text: " g/min", font: { size: 12,color:"black", weight: 100 }, position: "top" },
        number: { suffix: " g/min", font: { size: 16,color:"black", weight: 100 } }
    }

];



var layout= {
    autosize: true,
    margin: { t: percentage * height, r: percentage, l: percentage * width * 0.1, b: percentage * height * 2 },
    paper_bgcolor: "rgba(0,0,0,0)",
    plot_bgcolor: "rgba(0,0,0,0)"
};

Plotly.newPlot(Idcontainer, data, layout);
}

function gaugeTemp(Idcontainer,valueInput) {
    const container = document.getElementById(Idcontainer);
    const width = container.clientWidth;
    const height = container.clientHeight;
    const percentage = getScreenSize() //10%
   
    var data = [
    {
        type: "indicator",
        mode: "number+gauge",
        value: valueInput,
        gauge: {
            shape: "bullet",
            axis: { range: [0.0, 45.0],  ticks: "inside",
                tickmode: "auto", ticklen: height * 0.4, nticks: 20
            },
             bar: {
                color: "rgba(0, 0, 0, 0)", // Set the background color to transparent
                line: { color: "blue", width: 3},
                thickness: 1
            },
            steps: [
                { range: [0, 20], color: "red" },
                { range: [20, 25], color: "yellow" },
                { range: [25, 35], color: "green" },
                { range: [35, 40], color: "yellow" },
                { range: [40, 45], color: "red" }

            ]
        },
        domain: { x: [0, 1], y: [0, 1] },
       // title: { text: " °C", font: { size: 12,color:"black", weight: 100 }, position: "top" },
        number: { suffix: " °C", font: { size: 16,color:"black", weight: 100 } }
        
    }
];



var layout= {
    autosize: true,
    margin: { t: percentage * height, r: percentage, l: percentage * width*0.1, b: percentage * height * 2 },
    paper_bgcolor: "rgba(0,0,0,0)",
    plot_bgcolor: "rgba(0,0,0,0)"
};

Plotly.newPlot(Idcontainer, data, layout);
}

function gaugeGlazel(Idcontainer,valueInput) {
    const container = document.getElementById(Idcontainer);
    const width = container.clientWidth;
    const height = container.clientHeight;
    const percentage = getScreenSize() //10%
   
    var data = [
    {
        type: "indicator",
        mode: "number+gauge",
        value: valueInput,
        gauge: {
            shape: "bullet",
            axis: { range: [0, 2000],  ticks: "inside",
                tickmode: "auto", ticklen: height * 0.4, nticks: 20
            },
             bar: {
                color: "rgba(0, 0, 0, 0)", // Set the background color to transparent
                line: { color: "blue", width: 3},
                thickness: 1
            },
            steps: [
                { range: [0, 1550], color: "red" },
                { range: [1550, 1600], color: "yellow" },
                { range: [1600, 1850], color: "green" },
                { range: [1850, 1900], color: "yellow" },
                { range: [1900, 2000], color: "red" }

            ]
        },
        domain: { x: [0, 1], y: [0, 1] },
       // title: { text: "g/l", font: { size: 12,color:"black", weight: 100 }, position: "top" },
        number: { suffix:" g/l", font: { size: 16,color:"black", weight: 100 } }
       }
];



var layout= {
    autosize: true,
    margin: { t: percentage * height, r: percentage , l: percentage*width*0.1, b: percentage*height*2},
    paper_bgcolor: "rgba(0,0,0,0)",
    plot_bgcolor: "rgba(0,0,0,0)"
};


Plotly.newPlot(Idcontainer, data, layout);
}

function gaugeLitre(Idcontainer,valueInput) {
    const container = document.getElementById(Idcontainer);
    const width = container.clientWidth;
    const height = container.clientHeight;
    const percentage = getScreenSize() //10%
 
   
    var data = [
    {
        type: "indicator",
        mode: "number+gauge",
        value: valueInput,
        gauge: {
            shape: "bullet",
            axis: {
                range: [0.0, 75.0], ticks: "inside",
                tickmode: "auto", ticklen: height*0.4, nticks: 20
            },
             bar: {
                color: "rgba(0, 0, 0, 0)", // Set the background color to transparent
                line: { color: "blue", width: 3},
                thickness: 1
            },
            steps: [
                { range: [0, 15], color: "white" },
                { range: [15, 60], color: "green" },
                { range: [60, 70.0], color: "yellow" },
                { range: [70, 75.0], color: "red" },

            ]
        },
        domain: { x: [0, 1], y: [0, 1] },
            // title: { text: "l/min", font: { size: 12,color:"black", weight: 100 }, position: "top" },
            number: { suffix: " l/min", font: { size: 16, color: "black", weight: 100 } }
      
    }
];


var layout= {
    autosize: true,
    margin: { t: percentage * height, r: percentage , l: percentage*width*0.1, b: percentage*height*2},
    paper_bgcolor: "rgba(0,0,0,0)",
    plot_bgcolor: "rgba(0,0,0,0)"
};

Plotly.newPlot(Idcontainer, data, layout);
}


function gaugePressure(Idcontainer,valueInput) {
    
   
    var data = [
    {
        type: "indicator",
        mode: "number+gauge",
        value: valueInput,
        gauge: {
            shape: "bullet",
            axis: { range: [0.0, 10.0],  ticks: "inside",
                tickmode:"auto", ticklen: 40, nticks: 20
            },
             bar: {
                color: "rgba(0, 0, 0, 0)", // Set the background color to transparent
                line: { color: "blue", width: 3},
                thickness: 1
            },
            steps: [
                { range: [0, 7], color: "red" },
                { range: [7, 7.5], color: "yellow" },
                { range: [7.5, 8.5], color: "green" },
                { range: [8.5, 9.0], color: "yellow" },
                { range: [9.0, 10.0], color: "red" }


            ]
        },
        domain: { x: [0, 1], y: [0, 1] },
       // title: { text: "Bar", font: { size: 12,color:"black", weight: 100 }, position: "top" },
        number: { suffix:" Bar", font: { size: 16,color:"black", weight: 100 } }
        
    }
];

const container=document.getElementById(Idcontainer);
const width=container.clientWidth;
const height=container.clientHeight;
    const percentage = getScreenSize() //10%

var layout= {
    autosize: true,
    margin: { t: percentage * height, r: percentage , l: percentage*width*0.1, b: percentage*height*2},
    paper_bgcolor: "rgba(0,0,0,0)",
    plot_bgcolor: "rgba(0,0,0,0)"
};

Plotly.newPlot(Idcontainer, data, layout);
}

function TemperatureAcb() {
    let temp = document.getElementById('temperature').innerHTML;
    temp= temp.replace(",", ".");
    var data = [
        {
            domain: { x: [0, 1], y: [0, 1] },
            value: temp,
            title: { text: "HB6 °C" },
            type: "indicator",
            mode: "gauge+number",
            delta: { reference: 32 },
            gauge: {
                axis: { range: [30, 34] },
                bar: { color: "gray" },
                steps: [
                    { range: [31, 33], color: "green" },
                    { range: [33, 34], color: "yellow" },
                    { range: [30, 31], color: "yellow" }
                ]
            }
        }
    ];
    var element = document.getElementById('TempGauge');

    var layout = { width: element.offsetWidth, height: element.offsetHeight };
    Plotly.newPlot('TempGauge', data, layout);


}
function getNumber(text) {
    text = text.replace(",", ".");
    return text;
}