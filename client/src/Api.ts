const API_URL = process.env.REACT_APP_API_URL;

export function get<T>(path: string): Promise<T> {
  const res = fetch(`${API_URL}/${path}`, {
    method: "GET",
    mode: "cors",
    credentials: "include",
    headers: {
      "Content-type": "application/json",
    },
  }).then((res) => res.json() as T);

  return res;
}
