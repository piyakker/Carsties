"use client";

import { Pagination } from "flowbite-react";
import { useState } from "react";

type Props = {
  currentPage: number;
  pageCount: number;
  PageChanged: (pageNumber: number) => void;
};

export function AppPagination({ currentPage, pageCount, PageChanged }: Props) {
  return (
    <div className="flex overflow-x-auto sm:justify-center">
      <Pagination
        currentPage={currentPage}
        totalPages={pageCount}
        onPageChange={PageChanged}
        layout="pagination"
        showIcons
        className="text-blue-500 mb-5"
      />
    </div>
  );
}
