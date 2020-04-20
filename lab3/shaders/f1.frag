varying vec3 vUv;

uniform vec3 colorA;
uniform vec3 colorB;

void main() {
    vec3 color = vec3(0.0);

    color = mix(colorA, colorB, vUv.y+vUv.x);

    gl_FragColor = vec4(color, 1);
}
