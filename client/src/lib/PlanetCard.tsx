import "./PlanetCard.css";

type Props = {
  name: string;
  pictureUrl: string;
  link: boolean;
};

export default function PlanetCard(props: Props) {
  return props.link ? (
    <a href={`planet/${props.name}`}>
      <Card name={props.name} pictureUrl={props.pictureUrl} />
    </a>
  ) : (
    <Card name={props.name} pictureUrl={props.pictureUrl} />
  );
}

function Card({ name, pictureUrl }: { name: string; pictureUrl: string }) {
  return (
    <div className="card">
      <img src={pictureUrl} />
      <div className="text-wrapper">
        <p>{name}</p>
      </div>
    </div>
  );
}
