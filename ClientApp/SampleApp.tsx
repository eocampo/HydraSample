import { createRoot } from 'react-dom/client';
import { hydrateRoot } from 'react-dom/client';

import SampleCard from './components/SampleCard';
import * as React from 'react';

const container = document.getElementById('app');
// const root = createRoot(container); // createRoot(container!) if you use TypeScript
const root = hydrateRoot(container, <SampleCard />); // hydrateRoot(container!) if you use TypeScript
// root.render(<SampleCard />);