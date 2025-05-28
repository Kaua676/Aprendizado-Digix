import { useEffect, useRef } from "react";

function InputAutoFocus() {
  const inputRef = useRef();

  useEffect(() => {
    inputRef.current.focus();
  }, []);

  return <input ref={inputRef} type="text" placeholder="Digite algo..." />;
}

export default InputAutoFocus;
