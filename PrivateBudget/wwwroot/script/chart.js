class DonutChart {
    constructor(canvasSelector, width, data) {
        this.canvas = document.querySelector(canvasSelector);
        this.context = this.canvas.getContext("2d");
        this.data = data;
        this.width = width;

        this.calcDimensions();
        this.draw();

    }

    calcDimensions() {
        this.centerX = this.canvas.width / 2;
        this.centerY = this.canvas.height / 2;
        this.outerRadius = Math.min(this.centerX, this.centerY);
        this.innerRadius = this.outerRadius - this.outerRadius * this.width;
    }


    draw() {
        let lastDeg = 0;
        for (let vp of Object.entries(this.data)) {
            this.drawSegment(vp[0] + "CC", lastDeg, lastDeg + vp[1] * 360);
            lastDeg = lastDeg + vp[1] * 360;
        }
    }


    drawSegment(color, startDeg, endDeg) {
        let startRad = this.degToRad(startDeg - 90);
        let endRad = this.degToRad(endDeg - 90);

        let x0 = this.centerX + this.innerRadius * Math.cos(endRad);
        let y0 = this.centerY + this.innerRadius * Math.sin(endRad);

        let x1 = this.centerX + this.outerRadius * Math.cos(startRad);
        let y1 = this.centerY + this.outerRadius * Math.sin(startRad);

        this.context.fillStyle = color;
        let path = new Path2D();

        path.arc(this.centerX, this.centerY, this.outerRadius, startRad, endRad);
        path.lineTo(x0, y0);
        path.arc(this.centerX, this.centerY, this.innerRadius, endRad, startRad, true);
        path.lineTo(x1, y1);
        path.closePath();
        this.context.fill(path);

        return path;
    }

    degToRad(deg) {
        return deg * (Math.PI / 180)
    }
}