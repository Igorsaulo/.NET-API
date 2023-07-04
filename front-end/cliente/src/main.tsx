import React from 'react';
import ReactDOM from 'react-dom';
import { createRoot } from "react-dom/client";
import router from './routes';
import './index.css';
import Layout from './components/layout/layout';
import { RouterProvider } from 'react-router-dom';

createRoot(document.getElementById('root')).render(
  <React.StrictMode>
     <RouterProvider router={router} />
  </React.StrictMode>
);



