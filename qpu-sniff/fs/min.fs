uniform vec4 c1;
uniform vec4 c2;
void main(void) {
  gl_FragColor = min(c1, c2);
}

